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

namespace p09
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        List<char> list;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            list = new List<char>(textBox1.Text);
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                char del = buttonA.Text[0];
                while (list.Contains(del))
                {
                    list.Remove(del);
                }
                string chain;
                textBox1.Text = chain = library.Vypis(list);
            }
        }
    }
}
