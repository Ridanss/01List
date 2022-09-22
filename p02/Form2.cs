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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text);
            int k = Convert.ToInt32(textBoxK.Text);
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(-4, 21));
            }
            library.Vypis(list, listBox1);
            library.SmazaniLambda(list, k);
            library.Smazani(list, k);
            library.DruheMaximum(out int max, out int maxI, list);
        }
    }
}
