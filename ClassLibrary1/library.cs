using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    /// <summary>
    /// 
    /// </summary>
    public class library
    {
        /// <summary>
        /// vypise list
        /// </summary>
        /// <param name="list">vypisovany list</param>
        /// <param name="listbox">cileny listbox</param>
        public static void Vypis(List<int> list, ListBox listbox)  //p02
        {
        for (int i = 0; i < list.Count; i++)
            {
                listbox.Items.Add(list[i]);
            }
        }
        /// <summary>
        /// smaze prvky k pomoci lambda vyrazu
        /// </summary>
        /// <param name="list">vystupni list</param>
        /// <param name="k">mazany prvek</param>
        /// <returns>promazany list</returns>
        public static List<int> SmazaniLambda(List<int> list, int k)
        {
            list.RemoveAll(a => a == k);
            return list;
        }
        /// <summary>
        /// smaze prvky k bez lambda vyrazu
        /// </summary>
        /// <param name="list">vystupni list</param>
        /// <param name="k">mazany prvek</param>
        /// <returns>promazany list</returns>
        public static List<int> Smazani(List<int> list, int k)
        {
            while (list.Contains(k))
            {
                list.Remove(k);
            }
            return list;
        }
        /// <summary>
        /// najde druhe maximum
        /// </summary>
        /// <param name="max2">druhe maximum</param>
        /// <param name="max2I">index druheho maxima</param>
        /// <param name="list">vstupni list</param>
        public static void DruheMaximum(out int max2, out int max2I, List<int> list)
        {
            int max = -5;
            int maxI = 0;
            max2 = -5;
            max2I = 0;
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
        }
        /// <summary>
        /// generuje cela cisla do listu
        /// </summary>
        /// <param name="list">vstupni list</param>
        /// <param name="n">pocet prvku</param>
        /// <returns>vrati n prvku od -4 do 20</returns>
        public static List<int> Generace(List<int> list, int n, int x, int y)
        {
            list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(x, y));
            }
            return list;
        }

        /// <summary>
        /// vrati druhe maximum
        /// </summary>
        /// <param name="pomocny">vrati serazeny vstupni list</param>
        /// <param name="maxI">index druheho maxima</param>
        /// <returns>druhe maximum</returns>
        public static int DruhyNejvetsi(ref List<int> pomocny, out int maxI)
        {
            int max;
            int[] puvodni = new int[pomocny.Count];
            pomocny.CopyTo(puvodni);
            pomocny.Sort();
            if (pomocny.Count >= 2) max = pomocny[pomocny.Count - 2];
            else max = pomocny[0];
            maxI = Array.IndexOf(puvodni, max);
            return max;
        }

        public static List<int> AritPosloupnost(int n ,int a1, int d)
        {
            List<int> list = new List<int>(n);
            list[0] = a1;
            for (int i = 1; i <= n; i++)
            {
                list.Add(list[i--] + d);
            }
            return list;
        }
    }
}
