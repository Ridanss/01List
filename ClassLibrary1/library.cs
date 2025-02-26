﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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

        public static void Vypis(List<double> list, ListBox listbox)
        {
            for (int i = 0; i < list.Count; i++)
            {
                listbox.Items.Add(list[i]);
            }
        }

        public static void Vypis(List<string> list, ListBox listbox)
        {
            for (int i = 0; i < list.Count; i++)
            {
                listbox.Items.Add(list[i]);
            }
        }

        public static string Vypis(List<char> list)
        {
            string chain = string.Empty;
            foreach(char c in list)
            {
                chain += c;
            }
            return chain;
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
            list.Add(a1);
            for (int i = 1; i < n; i++)
            {
                list.Add(list[i-1] + d);
            }
            return list;
        }

        public static List<int> AritPoslPridat(int n, ref List<int> list)
        {
            int a1 = list[list.Count - 1];
            int d = list[list.Count - 1] - list[list.Count - 2];
            if (n >= 2)
            {
                for (int i = 0; i < n; i++)
                {
                    a1 += d;
                    list.Add(a1);
                }
            }
            return list;
        }

        public static List<double> GeoPosloupnost(int n, double a1, double a2)
        {
            double q = a2 / a1;
            List<double> list = new List<double>();
            list.Add(a1);
            list.Add(a2);
            for (int i = 2; i < n; i++)
            {
                a2 *= q;
                list.Add(a2);
            }
            return list;
        }

        public static bool GeoPoslSecist(int p, List<double> list, out double soucet)
        {
            soucet = 0;
            if (p > list.Count) return false;
            for (int i = 0; i < p; i++)
            {
                soucet += list[i];
            }
            return true;
            
        }

        public static void Uprava(ref List<char> list)
        {
            int i = 0;
            while (i < list.Count)
            {
                if (char.IsDigit(list[i])) list.Remove(list[i]);
                else if (char.IsLower(list[i]) && list[i] >= 'a' && list[i] <= 'z') list.Remove(list[i]);
                else i++;
            }
        }

        public static List<char> CharList(TextBox box1)
        {
            List<char> list = new List<char>();
            foreach (string item in box1.Lines)
            {
                list.Add(item[0]);
            }
            return list;
        }

        public static List<int> Prohozeni(List<int> list)
        {
            int min = 101, max = -101;
            int minI = -1, maxI = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    if (list[i] % 3 == 0 && list[i] < min)
                    {
                        min = list[i];
                        minI = i;
                    }
                }
                else if (list[i] > max)
                {
                    max = list[i];
                    maxI = i;
                }
            }
            if (maxI >= 0 && minI >= 0) (list[maxI], list[minI]) = (list[minI], list[maxI]);
            return list;
        }



    }
}
