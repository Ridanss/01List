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

namespace p08
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxN.Text, out int n))
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                List<int> list = new List<int>();
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    list.Add(rnd.Next(-100, 101));
                }
                library.Vypis(list, listBox1);
                list = library.Prohozeni(list);
                library.Vypis(list, listBox2);
            }
        }
    }
}
