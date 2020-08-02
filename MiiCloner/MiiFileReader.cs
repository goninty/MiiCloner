using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiiCloner
{
    // thank you https://stackoverflow.com/a/8621184

    class MiiFileReader : BinaryReader
    {
        public MiiFileReader(System.IO.Stream stream) : base(stream) { }

        private string ReadString(int length)
        {
            char[] str = new char[length/2];

            for (int i = 0; i < length/2; i++)
            {
                byte[] aChar = base.ReadBytes(2);
                Array.Reverse(aChar);
                str[i] = BitConverter.ToChar(aChar, 0);

            }

            return new string(str);
        }

        public string ReadMiiName()
        {
            base.BaseStream.Seek(2, SeekOrigin.Begin);
            return ReadString(20);
        }

        public string ReadCreatorName()
        {
            base.BaseStream.Seek(54, SeekOrigin.Begin);
            return ReadString(20);
        }

        public int[] ReadMiiMetadata()
        {
            base.BaseStream.Seek(0, SeekOrigin.Begin); // tbh idk how *ahem* best practice this is
            string binary = "";
            foreach (byte b in base.ReadBytes(2))
            {
                binary = string.Concat(binary, Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            // isGirl, month, day, favColor, isFavorite
            int[] metadata = new int[5];
            metadata[0] = Convert.ToUInt16(binary.Substring(1, 1), 2);
            metadata[1] = Convert.ToUInt16(binary.Substring(2, 4), 2);
            metadata[2] = Convert.ToUInt16(binary.Substring(6, 5), 2);
            metadata[3] = Convert.ToUInt16(binary.Substring(11, 4), 2);
            metadata[4] = Convert.ToUInt16(binary.Substring(15, 1), 2);

            return metadata;
        } 

        public string ReadMiiID()
        {
            base.BaseStream.Seek(23, SeekOrigin.Begin);
            byte[] miiID = base.ReadBytes(4);
            return BitConverter.ToString(miiID);
        }

    }
}
