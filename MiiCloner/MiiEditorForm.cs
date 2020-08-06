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

        // ints below used to keep track of when user is flicking between things
        private int isGirl;
        private int isFavorite;
        private int colorIndex; // current selected color in terms of index along colors array

        private Image[] gender = new Image[2];
        private Image[] favorite = new Image[2];
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
            gender[0] = Properties.Resources.Male;
            gender[1] = Properties.Resources.Female;
            favorite[0] = Properties.Resources.NoFavorite;
            favorite[1] = Properties.Resources.YesFavorite;

            txtMiiName.Text = mii.miiName;
            txtCreatorName.Text = mii.creatorName;
            isGirl = mii.isGirl;
            pbGender.Image = gender[isGirl];
            colorIndex = mii.favColor;
            pnColorFill.BackColor = colors[colorIndex];
            isFavorite = mii.isFavorite;
            pbFavorite.Image = favorite[isFavorite];
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

        private void saveMiiDetails()
        {
            mii.miiName = txtMiiName.Text;
            mii.creatorName = txtCreatorName.Text;
            mii.miiID = generateMiiID(new Random());
            mii.isGirl = isGirl;
            mii.favColor = colorIndex;
            mii.isFavorite = isFavorite;
            mii.month = (int)nudMonth.Value;
            mii.day = (int)nudDay.Value;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveMiiDetails();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Mii File (*.mii)|*.mii|MiiGX File (*.miigx)|*.miigx";
            sfd.RestoreDirectory = true;
            sfd.FileName = BitConverter.ToString(mii.miiID);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MiiFileWriter mfw = new MiiFileWriter(File.Open(sfd.FileName, FileMode.Create));
                mfw.Write(mii);
                mfw.Close();
                MessageBox.Show("Mii successfully cloned!", "Mii Cloner");
            }
        }

        private void btnMogi_Click(object sender, EventArgs e)
        {
            if (txtMiiName.Text.Length > 8)
            {
                MessageBox.Show("Mii name too long to add a letter to the front. Please shorten it!", "Mii Cloner");
            }
            else
            {
                saveMiiDetails();
                

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    FileFormatForm fff = new FileFormatForm();
                    if (fff.ShowDialog() == DialogResult.OK)
                    {
                        if (MessageBox.Show("Clone 26 miis into " + fbd.SelectedPath + "?", "Mii Cloner", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MiiFileWriter mfw;
                            Random rnd = new Random();
                            for (char c = 'A'; c <= 'Z'; c++)
                            {
                                mii.miiName = c.ToString() + " " + txtMiiName.Text;
                                mii.miiID = generateMiiID(rnd);
                                mfw = new MiiFileWriter(File.Open(fbd.SelectedPath + "\\" + mii.miiName + fff.returnValue, FileMode.Create));
                                mfw.Write(mii);
                                mfw.Close();
                            }
                            MessageBox.Show("Mogi miis created!", "Mii Cloner");
                        }
                    }
                }
            }
        }

        // now why do i handle both the click and double click events?
        // it's because only handling click meant that rapid clicks wouldn't register
        // because they would be interpreted as double clicks
        // this is literally nothing but a QoL improvement
        // and because i am pedantic

        private void changeGender()
        {
            isGirl = Math.Abs(1 - isGirl);
            pbGender.Image = gender[isGirl];
            pbGender.Invalidate();
        }
        private void pbGender_Click(object sender, EventArgs e)
        {
            changeGender();
        }

        private void pbGender_DoubleClick(object sender, EventArgs e)
        {
            changeGender();
        }

        private void changeColor()
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            pnColorFill.BackColor = colors[colorIndex];
            pnColorFill.Invalidate();
        }
        private void pnColorFill_Click(object sender, EventArgs e)
        {
            changeColor();
        }
        private void pnColorFill_DoubleClick(object sender, EventArgs e)
        {
            changeColor();
        }

        private void changeFavorite()
        {
            isFavorite = Math.Abs(1 - isFavorite);
            pbFavorite.Image = favorite[isFavorite];
        }

        private void pbFavorite_Click(object sender, EventArgs e)
        {
            changeFavorite();
        }

        private void pbFavorite_DoubleClick(object sender, EventArgs e)
        {
            changeFavorite();
        }

        private void nudMonth_ValueChanged(object sender, EventArgs e)
        {
            // February
            if (nudMonth.Value == 2)
            {
                nudDay.Maximum = 29;
            }
            // months with 30 days
            else if (Array.Exists(new int[] { 4, 6, 9, 11 }, elem => elem == nudMonth.Value))
            {
                nudDay.Maximum = 30;
            }
            else
            {
                nudDay.Maximum = 31;
            }
        }

        private void MiiEditorForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        // generating random new mii ID
        // why do I pass in an instance of Random?
        // this is why: https://stackoverflow.com/a/768001
        // this caused me a lot of trouble
        // generating a random id between 0x00000000 and 0xFFFFFFFF doesn't work
        // however for me at least, setting the first byte between 0x80-0x86 works
        // so here i set it to 0x85
        // i need to investigate this further :(
        private byte[] generateMiiID(Random rnd)
        {
            byte[] id1 = { 133 };
            byte[] id2 = BitConverter.GetBytes(rnd.Next(0, 16777215));

            byte[] idBytes = new byte[sizeof(uint)];
            Array.Copy(id1, 0, idBytes, 0, 1);
            Array.Copy(id2, 0, idBytes, 1, 3);

            return idBytes;
        }
    }
}