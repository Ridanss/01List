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

namespace p07
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                List<char> list = new List<char>();
                foreach(string item in textBox1.Lines)
                {
                    list.Add(item[0]);
                }
                library.Vypis(list, listBox1);
                library.Uprava(ref list);
                library.Vypis(list, listBox2);
            }
        }
    }
}
