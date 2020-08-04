using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiiCloner
{
    // mii attributes taken from http://wiibrew.org/wiki/Mii_Data#Mii_format
    class Mii
    {
        public byte[] miiFile;
        public string miiName { get; set; }
        public string creatorName { get; set; }
        public byte[] miiID { get; set; }
        public int isGirl { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int favColor { get; set; } // 0 - 11
        public int isFavorite { get; set; }

        public Mii(byte[] miiFile, string miiName, string creatorName, byte[] miiID, int[] metadata)
        {
            this.miiFile = miiFile;
            this.miiName = miiName;
            this.creatorName = creatorName;
            this.miiID = miiID;
            this.isGirl = metadata[0];
            this.month = metadata[1];
            this.day = metadata[2];
            this.favColor = metadata[3];
            this.isFavorite = metadata[4];

            Console.WriteLine("mii name length: " + this.miiName.Length);
        }

        public void checkFields()
        {
            Console.WriteLine(this.miiName);
            Console.WriteLine(this.creatorName);
            Console.WriteLine(BitConverter.ToString(this.miiID));
            Console.WriteLine(this.isGirl);
            Console.WriteLine(this.month);
            Console.WriteLine(this.day);
            Console.WriteLine(this.favColor);
            Console.WriteLine(this.isFavorite);
            Console.WriteLine("mii name length: " + this.miiName.Length);
        }
    }

}
