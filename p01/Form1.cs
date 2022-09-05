using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (textBoxN.Text != string.Empty)
            {
                n = Convert.ToInt32(textBoxN.Text);
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    list.Add(rnd.Next(1, 101));
                    listBox1.Items.Add(list[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Sort();
            string full = list[0].ToString();
            for (int i = 1; i < list.Count; i++)
            {
                full += ", " + list[i].ToString();
            }
            MessageBox.Show(full);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
