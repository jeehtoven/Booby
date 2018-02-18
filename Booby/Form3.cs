using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booby
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program p = new Program();
            p.Clone(textBox1.Text, textBox2.Text);
            MessageBox.Show("Operation complete. Press OK to close this window.");
            this.Close();
        }
    }
}
