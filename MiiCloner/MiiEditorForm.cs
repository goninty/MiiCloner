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

            MiiFileWriter mfw = new MiiFileWriter(File.Open("clone3.mii", FileMode.Create));
            mfw.Close();
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

            MiiFileWriter mfw = new MiiFileWriter(File.Open("clone2.mii", FileMode.Create));
            mfw.Write(mii);
            mfw.Close();
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
       
    }
}
