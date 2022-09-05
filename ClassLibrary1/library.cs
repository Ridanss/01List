using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class library
    {
        public static void Vypis(List<int> list, ListBox listbox)
        {
        for (int i = 0; i < list.Count; i++)
            {
                listbox.Items.Add(list[i]);
            }
        }

        public static List<int> Smazani(List<int> list)
        {

        }
    }
}
