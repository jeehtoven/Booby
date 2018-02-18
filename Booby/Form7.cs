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

namespace Booby
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();

            var directories = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory);

            foreach (string directory in directories)
            {
                var dir = new DirectoryInfo(directory);
                var dirName = dir.Name;
                comboBox1.Items.Add(dirName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program p = new Program();

            foreach (string file in listBox1.Items)
            {
                p.StagingArea(comboBox1.Text, file);
            }

            MessageBox.Show("Operation complete. Press OK to close this window.");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e) //Browse...
        {
            Program p = new Program();
            var files = p.BrowseRepository(comboBox1.Text);

            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program p = new Program();
            var files = p.BrowseRepository(comboBox1.Text);

            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }
    }
}
