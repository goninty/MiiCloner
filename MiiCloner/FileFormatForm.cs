using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiiCloner
{
    public partial class FileFormatForm : Form
    {
        private string[] formats = { ".mii", ".miigx" };
        public string returnValue { get; set; }

        public FileFormatForm()
        {
            InitializeComponent();
        }

        private void FileFormatForm_Load(object sender, EventArgs e)
        {
            cbFormat.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.returnValue = formats[cbFormat.SelectedIndex];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
