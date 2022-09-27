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

namespace p04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                int n = Convert.ToInt32(textBox1.Text);
                Random rnd = new Random();
                List<int> list = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    list.Add(rnd.Next(-6, 24));
                }
                library.Vypis(list, listBox1);
                list.Reverse();
                library.Vypis(list, listBox2);
                int min = list.Where(x => x.Equals(list.Min())).Count();
                int minimal = list.Min();
                while (min > 0)
                {
                    int i = list.IndexOf(minimal);
                    listBox3.Items.Add(minimal + " [" + i + "]");
                    list[i] = -6;
                    min--;
                }

            }
        }
    }
}
