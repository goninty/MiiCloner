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
    public partial class OpenMiiForm : Form
    {
        public OpenMiiForm()
        {
            InitializeComponent();
        }
        private void btnOpenMii_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mii Files (*.mii; *.mae)|*.mii;*.mae";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MiiEditorForm miiEditorForm = new MiiEditorForm(ofd.FileName);
                miiEditorForm.Show();
            }
        }

        private void btnOpenMii_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var fileExt = Path.GetExtension(files[0]).ToLower();

            // giving a *paper mario mario voice* "nono" symbol if they try to drop either
            // too many files or anything that's not a mii file
            if (files.Length != 1 || (!(fileExt.Equals(".mii") || fileExt.Equals(".mae"))))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            else
            {
                e.Effect = DragDropEffects.Copy;
                return;
            }
 
        }

        private void btnOpenMii_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((string[]) e.Data.GetData(DataFormats.FileDrop))[0];
            MiiEditorForm miiEditorForm = new MiiEditorForm(filePath);
            miiEditorForm.Show();
        }
    }
}
