using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiiCloner
{
    public partial class MiiEditorForm : Form
    {
        Mii mii;
        private int isGirl;
        private int isFavorite;
        private int colorIndex; // current selected color in terms of index along colors array
        private Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.LawnGreen,
                                   Color.DarkGreen, Color.Blue, Color.LightBlue, Color.Pink,
                                   Color.Purple, Color.SaddleBrown, Color.White, Color.Black };

        public MiiEditorForm(string filePath)
        {
            InitializeComponent();
            var mfr = new MiiFileReader(new FileStream(filePath, FileMode.Open));
            mii = new Mii(mfr.ReadBytes(74), mfr.ReadMiiName(), mfr.ReadCreatorName(), mfr.ReadMiiID(), mfr.ReadMiiMetadata());
            mfr.Close();
        }

        private void MiiClonerForm_Load(object sender, EventArgs e)
        {
            txtMiiName.Text = mii.miiName;
            txtCreatorName.Text = mii.creatorName;
            isGirl = mii.isGirl;
            pbGender.ImageLocation = "./images/gender/" + isGirl.ToString() + ".png";
            colorIndex = mii.favColor;
            pnColorFill.BackColor = colors[colorIndex];
            isFavorite = mii.isFavorite;
            pbFavorite.ImageLocation = "./images/favorite/" + isFavorite.ToString() + ".png";
            nudMonth.Value = mii.month;
            nudDay.Value = mii.day;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtMiiName.Enabled = true;
            txtCreatorName.Enabled = true;
            pbGender.Enabled = true;
            pnColorFill.Enabled = true;
            pbFavorite.Enabled = true;
            nudMonth.Enabled = true;
            nudDay.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {


            mii.miiName = txtMiiName.Text;
            mii.creatorName = txtCreatorName.Text;
            mii.isGirl = isGirl;
            mii.favColor = colorIndex;
            mii.isFavorite = isFavorite;
            mii.month = (int) nudMonth.Value;
            mii.day = (int) nudDay.Value;

            mii.checkFields();
            BinaryWriter bw = new BinaryWriter(File.Open("clone.mii", FileMode.Create));
            bw.Write(packageIntoBytes());
            bw.Close();
        }

        private void pbGender_Click(object sender, EventArgs e)
        {
            isGirl = Math.Abs(1 - isGirl);
            pbGender.ImageLocation = "./images/gender/" + isGirl.ToString() + ".png";
        }
        private void pnColorFill_Click(object sender, EventArgs e)
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            pnColorFill.BackColor = colors[colorIndex];
        }

        private void pbFavorite_Click(object sender, EventArgs e)
        {
            isFavorite = Math.Abs(1 - isFavorite);
            pbFavorite.ImageLocation = "./images/favorite/" + isFavorite.ToString() + ".png";
        }

        // this method is definitely in the wrong place right now
        // please move this later please god
        // also tidy it up ffs
        private byte[] packageIntoBytes()
        {
            // length in bytes
            const int METADATA_LENGTH = 2;
            const int MII_NAME_LENGTH = 20;
            const int MII_ID_LENGTH = 4;
            const int MII_CREATOR_NAME_LENGTH = 20;

            var miiFile = mii.miiFile;
            
            // packaging metadata into bytes
            string metadataBinary = 0 + // invalid
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

            Console.WriteLine(metadataBinary);
            Console.WriteLine(BitConverter.ToString(metadataBytes));

            // packaging mii name into bytes
            byte[] miiNameBytes = new byte[MII_NAME_LENGTH];
            int j = 0; // going sicko mode here folks
            for (int i = 0; i < mii.miiName.Length; i++)
            {
                byte[] currChar = BitConverter.GetBytes(mii.miiName[i]);
                miiNameBytes[j] = currChar[1];
                miiNameBytes[j + 1] = currChar[0];
                j = j + 2; // god dammit
            }

            Console.WriteLine(BitConverter.ToString(miiNameBytes));

            // incrementing mii ID by one and packaging into bytes
            byte[] miiIDBytes = mii.miiID;
            Array.Reverse(miiIDBytes);
            uint miiIDInteger = BitConverter.ToUInt32(miiIDBytes, 0);
            miiIDInteger++;
            miiIDBytes = BitConverter.GetBytes(miiIDInteger);
            Array.Reverse(miiIDBytes);
            Console.WriteLine(BitConverter.ToString(miiIDBytes));


            // packaging creator name into bytes
            byte[] creatorNameBytes = new byte[MII_CREATOR_NAME_LENGTH];
            j = 0; // going sicko mode here again pog champ
            for (int i = 0; i < mii.creatorName.Length; i++)
            {
                byte[] currChar = BitConverter.GetBytes(mii.creatorName[i]);
                creatorNameBytes[j] = currChar[1];
                creatorNameBytes[j + 1] = currChar[0];
                j = j + 2;
            }

            Console.WriteLine(BitConverter.ToString(creatorNameBytes));

            // actually writing to the complete byte array
            int seekVal = 0; // where we are writing to in the byte array
            for (int i = 0; i < METADATA_LENGTH; i++)
            {
                miiFile[i] = metadataBytes[i];
            }

            seekVal = 2;
            for (int i = 0; i < MII_NAME_LENGTH; i++)
            {
                miiFile[seekVal + i] = miiNameBytes[i];
            }

            seekVal = 24;
            for (int i = 0; i < MII_ID_LENGTH; i++)
            {
                miiFile[seekVal + i] = miiIDBytes[i];
            }

            seekVal = 54;
            for (int i = 0; i < MII_CREATOR_NAME_LENGTH; i++)
            {
                miiFile[seekVal + i] = creatorNameBytes[i];
            }

            //miiFile
            return miiFile;
        }
       
    }
}
