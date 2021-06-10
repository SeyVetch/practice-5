using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Маханов 1исп11-17 практика 5
/// </summary>

namespace ConsoleApp7
{
    class Program
    {
        static int prog2(int n)
        {
            int res = 1;
            for (int i = n; n > 0; n -= 2)
            {
                res *= i;
            }
            return res;
        }
        static int prog3a(int n)
        {
            if (n > 0)
            {
                return n * n + prog3a(n);
            }
            return 0;
        }
        static int prog3b(int n)
        {
            int res = 0;
            for (int i = n; i > 0; i--)
            {
                res += i * i;
            }
            return res;
        }
        static int[] prog4(int[] n, int x)
        {
            int l;
            if (x > n.Length)
            {
                l = n.Length;
            }
            else
            {
                l = x;
            }
            int[] a = new int[x];
            for (int i = 0; i < l; i++)
            {
                a[i] = n[i];
            }
            return a;
        }
        static int[] prog5(char[] a)
        {
            int[] res = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = (int)a[i];
            }
            return res;
        }
        static double prog6(int[] a)
        {
            double res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                res += a[i];
            }
            return res / a.Length;
        }
        static void prog7(int[,] n, int x, int y)
        {
            int a = 0, b = 0;
            int max = int.MinValue;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (max < n[i, j])
                    {
                        max = n[i, j];
                        a = i;
                        b = j;
                    }
                }
            }
            x = a;
            y = b;
        }
        static void prog8(char[] c)
        {
            char[] a = (char[])c.Clone();
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = a[c.Length - i - 1];
            }
        }
        static char[] prog9(char x, char y)
        {
            char a, b;
            if ((int)x > (int)y)
            {
                b = x;
                a = y;
            }
            else
            {
                a = x;
                b = y;
            }
            char[] res = new char[(int)b - (int)a + 1];
            for (int i = 0; i < (int)b - (int)a + 1; i++)
            {
                res[i] = (char)((int)a + i);
            }
            return res;
        }
        static int[] prog9(int x, int y)
        {
            int a, b;
            if (x > y)
            {
                b = x;
                a = y;
            }
            else
            {
                a = x;
                b = y;
            }
            int[] res = new int[b - a + 1];
            for (int i = 0; i < b - a + 1; i++)
            {
                res[i] = a + i;
            }
            return res;
        }
        static int[] prog10(params int[] n)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > max)
                {
                    max = n[i];
                }
                if (n[i] < min)
                {
                    min = n[i];
                }
            }
            int[] res = { max, min };
            return res;
        }
        static string prog11(string s, params char[] c)
        {
            return Convert.ToString(c) + s;
        }
        static void Main(string[] args)
        {
        }
    }
}
