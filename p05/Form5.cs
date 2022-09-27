using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty)
            {
                int n = Convert.ToInt32(textBox1.Text);
                int a1 = Convert.ToInt32(textBox2.Text);
                int d = Convert.ToInt32(textBox3.Text);
                List<int> list = library.AritPosloupnost(n, a1, d);
                library.Vypis(list, listBox1);
            }
        }
    }
}
