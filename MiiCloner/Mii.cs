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
        public string miiName { get; set; }
        public string creatorName { get; set; }
        public string miiID { get; set; }
        public int isGirl { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int favColor { get; set; } // 0 - 11
        public int isFavorite { get; set; }

        public Mii(string miiName, string creatorName, string miiID, int[] metadata)
        {
            this.miiName = miiName;
            this.creatorName = creatorName;
            this.miiID = miiID;
            this.isGirl = metadata[0];
            this.month = metadata[1];
            this.day = metadata[2];
            this.favColor = metadata[3];
            this.isFavorite = metadata[4];

            Console.WriteLine(this.miiName);
            Console.WriteLine(this.creatorName);
            Console.WriteLine(this.miiID);
            Console.WriteLine(this.isGirl);
            Console.WriteLine(this.month);
            Console.WriteLine(this.day);
            Console.WriteLine(this.favColor);
            Console.WriteLine(this.isFavorite);


        }
    }

}
