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
    public partial class Compression : Form
    {
        public static class Items
        {
            public static string Item;
        }
        
        public Compression()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main openform = new Main();
            openform.Show();
            this.Hide();
        }

        private void btnuploadpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Text File(.txt)|*.txt";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in ofd.FileNames)
                {
                    listBoxPath.Items.Add(item);
                    Items.Item = item;
                }

            }
            //MessageBox.Show(Items.Item);
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

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxPath_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblheading_Click(object sender, EventArgs e)
        {

        }

        private void btncompress_Click(object sender, EventArgs e)
        {  
            List<Node> nodeList;
            Tree tree = new Tree();
            nodeList = tree.getListFromFile();
            tree.TreeList(nodeList);
            tree.setBitcode("", nodeList[0]);
            tree.Ascii("", nodeList[0]);
            tree.Filewrite(nodeList[0]);
            this.Close();
            Application.Exit();
        }

        private void lblupload_Click(object sender, EventArgs e)
        {

        }

        private void lbltxtfile_Click(object sender, EventArgs e)
        {

        }

        private void panelfooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Compression_Load(object sender, EventArgs e)
        {

        }
    }
}
