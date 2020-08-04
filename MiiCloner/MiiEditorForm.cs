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
        private Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.LightGreen,
                                   Color.DarkGreen, Color.Blue, Color.LightBlue, Color.Pink,
                                   Color.Purple, Color.Brown, Color.White, Color.Black };
        public MiiEditorForm(string filePath)
        {
            InitializeComponent();
            var mfr = new MiiFileReader(new FileStream(filePath, FileMode.Open));
            mii = new Mii(mfr.ReadMiiName(), mfr.ReadCreatorName(), mfr.ReadMiiID(), mfr.ReadMiiMetadata());
            mfr.Close();
        }

        private void MiiClonerForm_Load(object sender, EventArgs e)
        {
            txtMiiName.Text = mii.miiName;
            txtCreatorName.Text = mii.creatorName;
            pbGender.ImageLocation = "./images/gender/" + mii.isGirl.ToString() + ".png";
            pnColorFill.BackColor = colors[mii.favColor];
            pbFavorite.ImageLocation = "./images/favorite/" + mii.isFavorite.ToString() + ".png";
            txtMonth.Text = mii.month.ToString();
            txtDay.Text = mii.day.ToString();
        }

    }
}
