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
            if (textBoxN.Text != String.Empty && textBoxA1.Text != String.Empty && textBoxD.Text != String.Empty)
            {
                listBox1.Items.Clear();
                int n = Convert.ToInt32(textBoxN.Text);
                int a1 = Convert.ToInt32(textBoxA1.Text);
                int d = Convert.ToInt32(textBoxD.Text);
                List<int> list = library.AritPosloupnost(n, a1, d);
                library.Vypis(list, listBox1);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 2)
            {
                if (textBoxAdd.Text != String.Empty)
                {
                    int length = listBox1.Items.Count;
                    int n = Convert.ToInt32(textBoxAdd.Text);
                    int d = Convert.ToInt32(Convert.ToInt32(listBox1.Items[length - 1]) - Convert.ToInt32(listBox1.Items[length - 2]));
                    int a1 = Convert.ToInt32(Convert.ToInt32(listBox1.Items[length - 1]));
                    List<int> list = library.AritPoslPridat(n, d, a1);
                    library.Vypis(list, listBox1);
                }
            }
        }
    }
}
