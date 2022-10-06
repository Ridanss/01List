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
            if (listBox1.Items.Count >= 2)
            {
                if (textBoxAdd.Text != String.Empty)
                {
                    List<int> list = new List<int>();
                    foreach(int item in listBox1.Items)
                    {
                        list.Add(item);
                    }
                    int n = Convert.ToInt32(textBoxAdd.Text);
                    library.AritPoslPridat(n, ref list);
                    listBox1.Items.Clear();
                    library.Vypis(list, listBox1);
                }
            }
        }
    }
}
