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
    public partial class Form8 : Form
    {
        public Form8()
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
            p.Commit(comboBox1.Text, textBox1.Text);
            MessageBox.Show("Operation complete. Press OK to close this window.");
            this.Close();
        }
    }
}
