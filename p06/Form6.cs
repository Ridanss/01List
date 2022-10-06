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

namespace p06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int n;
            double a1, a2;
            if (int.TryParse(textBoxN.Text, out n) && double.TryParse(textBoxA1.Text, out a1) && double.TryParse(textBoxA2.Text, out a2))
            {
                listBox1.Items.Clear();
                List<double> list = library.GeoPosloupnost(n, a1, a2);
                library.Vypis(list, listBox1);
            }
        }

        private void buttonSoucet_Click(object sender, EventArgs e)
        {
            int p;
            labelSoucet.Text = "součet:";
            if (int.TryParse(textBoxP.Text, out p))
            {
                List<double> list = new List<double>();
                foreach(double item in listBox1.Items)
                {
                    list.Add(item);
                }
                bool possible = library.GeoPoslSecist(p, list, out double soucet);
                if (possible) labelSoucet.Text = String.Format("součet:\n{0}", soucet);
                else labelSoucet.Text = "součet:\nnebyl možný";
            }
        }
    }
}
