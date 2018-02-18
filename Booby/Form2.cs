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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program whoAmI = new Program();
            whoAmI.WhoAmI(textBox1.Text, textBox2.Text);
            MessageBox.Show("Configuration complete. Press OK to continue");
            this.Close();
        }
    }
}
