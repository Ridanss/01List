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

        public static List<int> SmazaniLambda(List<int> list, int k)
        {
            list.RemoveAll(a => a == k);
            return list;
        }

        public static List<int> Smazani(List<int> list, int k)
        {
            while (list.Contains(k))
            {
                list.Remove(k);
            }
            return list;
        }

        public static void DruheMaximum(out int max, out int maxI, List<int> list)
        {
            max = -5;
            maxI = 0;
            int max2 = -5;
            int max2I = 0;
            for (int i =0; i < list.Count; i++)
            {
                if (list[i] >= max)
                {
                    max2 = max;
                    max2I = maxI;
                    max = list[i];
                    maxI = i;
                }
                else if (list[i] > max2)
                {
                    max2 = list[i];
                    max2I = i;
                }
            }
            maxI = max2I;
        }
        public static List<int> Generace(List<int> list, int n)
        {
            list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(-4, 21));
            }
            return list;
        }
    }
}
