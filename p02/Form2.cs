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

namespace p02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBoxN.Text);
            list = library.Generace(list, n);
            library.Vypis(list, listBox1);
        }

        private void buttonLambda_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int k = Convert.ToInt32(textBoxK.Text);
            library.Vypis(library.SmazaniLambda(list, k), listBox2);
        }

        private void buttonNoLambda_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int k = Convert.ToInt32(textBoxK.Text);
            library.Vypis(library.Smazani(list, k), listBox3);
        }
    }
}
