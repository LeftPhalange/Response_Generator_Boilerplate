using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Response_Generator_Boilerplate
{
    public partial class MainForm : Form
    {
        private ResponseGenerator _rgInstance = new ResponseGenerator(Properties.Settings.Default.Responses);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) // will be left here
        {
        }

        private void _generate_Click(object sender, EventArgs e) => _responseOutput.Text = _rgInstance.GenerateResponse();
        private void _copyToClipboard_Click(object sender, EventArgs e) => Clipboard.GetData(_responseOutput.Text);
        private void _about_Click(object sender, EventArgs e) => new About().ShowDialog();
        private void _exit_Click(object sender, EventArgs e) => Close();
    }
}
