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
        public MiiEditorForm(string filePath)
        {
            InitializeComponent();
            var mfr = new MiiFileReader(new FileStream(filePath, FileMode.Open));
            lblMiiName.Text = mfr.ReadMiiName();
            Console.WriteLine(mfr.ReadCreatorName());
            Console.WriteLine(mfr.ReadMiiID());

            foreach (int i in mfr.ReadMiiMetadata())
            {
                Console.WriteLine(i);
            }
        }

        private void MiiClonerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
