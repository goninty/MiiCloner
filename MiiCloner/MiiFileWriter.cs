using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiiCloner
{
    class MiiFileWriter : BinaryWriter
    {
        // lengths in bytes
        const int METADATA_LENGTH = 2;
        const int NAME_LENGTH = 20; // mii name and creator name have same max length
        const int MII_ID_LENGTH = 4;

        Mii mii;
        byte[] miiFile;

        public MiiFileWriter(System.IO.Stream stream) : base(stream) { }

        public void Write(Mii mii)
        {
            this.mii = mii;
            // essentially just copy the original byte array
            // so we can overwrite the parts of it we need to
            this.miiFile = mii.miiFile;
            base.Write(packIntoBytes());
        }

        // takes the edited mii attributes and packs them into a single byte array
        // that can be passed to regular BinaryWriter and written to a file
        // i need to clean this up
        // also should i split it into different methods? probably a good idea huh
        // also also i know this is a roundabout way of doing things i could've just written these bytes directly
        // instead of packing them into a byte array and writing that as a whole
        // but shhhhh
        private byte[] packIntoBytes()
        {
            // actually writing to the complete byte array

            byte[] metadata = packMetadata();
            int seekVal = 0; // where we are writing to in the byte array
            for (int i = 0; i < METADATA_LENGTH; i++)
            {
                miiFile[i] = metadata[i];
            }

            byte[] miiName = packName(mii.miiName);
            seekVal = 2;
            for (int i = 0; i < NAME_LENGTH; i++)
            {
                miiFile[seekVal + i] = miiName[i];
            }

            byte[] miiID = mii.miiID;
            seekVal = 24;
            for (int i = 0; i < MII_ID_LENGTH; i++)
            {
                miiFile[seekVal + i] = miiID[i];
            }

            byte[] creatorName = packName(mii.creatorName);
            seekVal = 54;
            for (int i = 0; i < NAME_LENGTH; i++)
            {
                miiFile[seekVal + i] = creatorName[i];
            }

            return miiFile;
        }

        // packaging metadata into bytes
        private byte[] packMetadata()
        {
            // format of the 2 bytes of metadata taken from http://wiibrew.org/wiki/Mii_Data#Mii_format
            string metadataBinary = 1 + // invalid bit (no effect)
                                    Convert.ToString(mii.isGirl, 2).PadLeft(1, '0') +
                                    Convert.ToString(mii.month, 2).PadLeft(4, '0') +
                                    Convert.ToString(mii.day, 2).PadLeft(5, '0') +
                                    Convert.ToString(mii.favColor, 2).PadLeft(4, '0') +
                                    Convert.ToString(mii.isFavorite, 2).PadLeft(1, '0');

            // https://stackoverflow.com/a/3436456
            byte[] metadataBytes = new byte[METADATA_LENGTH];
            for (int i = 0; i < METADATA_LENGTH; ++i)
            {
                metadataBytes[i] = Convert.ToByte(metadataBinary.Substring(8 * i, 8), 2);
            }

            return metadataBytes;
        }

        // used for both mii name and creator name
        private byte[] packName(string name)
        {
            byte[] nameBytes = new byte[NAME_LENGTH];
            int j = 0; // going sicko mode here folks
            for (int i = 0; i < name.Length; i++)
            {
                byte[] currChar = BitConverter.GetBytes(name[i]);
                // have to swap because big endian lol
                nameBytes[j] = currChar[1];
                nameBytes[j + 1] = currChar[0];
                j = j + 2; // god dammit
            }

            return nameBytes;
        }
    }
}
