using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICTPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPaper.Clear();
            txtPaper.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var fileName = "text.txt";
            folderBrowserDialog.ShowDialog();
            var selectedFolder = folderBrowserDialog.SelectedPath;
        }
    }
}
