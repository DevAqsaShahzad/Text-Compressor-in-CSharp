using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedGUIandCode
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btntxtCompression_Click(object sender, EventArgs e)
        {

            Compression openform = new Compression();
            openform.Show();
            this.Hide();
        }

        private void btntxtDecompression_Click(object sender, EventArgs e)
        {
            Decompression openform = new Decompression();
            openform.Show();
            this.Hide();
        }
    }
}
