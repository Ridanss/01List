﻿using ClassLibrary1;
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
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                List<char> list = library.CharList(textBox1);
                library.Vypis(list, listBox1);
                library.Uprava(ref list);
                library.Vypis(list, listBox2);
            }
        }
    }
}
