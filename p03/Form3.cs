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

namespace p03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (textBoxN.Text != String.Empty)
            {
                listBox1.Items.Clear();
                List<int> list = new List<int>();
                int n = Convert.ToInt32(textBoxN.Text);
                list = library.Generace(list, n, -3, 7);
                list.RemoveAll(a => a == 0);
                library.Vypis(list, listBox1);
                labelVysl.Text = String.Format("Druhe maximum je {0}[{1}]", library.DruhyNejvetsi(list, out int maxI), maxI);
            }
        }
    }
}
