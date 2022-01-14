using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3
{
    namespace Task3
    {
        struct Aray
        {
            char[] a;
            public Aray(string a)
            {
                this.a = new char[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    this.a[i] = a[i];
                }
            }
            public Aray(int b, char c)
            {
                a = new char[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = c;
                }
            }
            public char this[int i]
            {
                get
                {
                    return a[i];
                }
                set
                {
                    a[i] = value;
                }
            }
            public override string ToString()
            {
                string o = "";
                for (int i = 0; i < a.Length; i++)
                {
                    o += ("Символ: " + a[i] + ".\tЧисловое значение: " + (int)a[i] + "\n");
                }
                return o;
            }
            public void Pora()
            {
                char[] b = new char[a.Length];
                for (int i = a.Length - 1, c = 0; i >= 0; i--, c++)
                {
                    b[c] = a[i];
                }
                a = b;
            }
        }
        class Program
        {
            static void run(string[] args)
            {
                Aray a = new Aray(3, 'b');
                a.Pora();
                a[0] = 'u';
                a[2] = 'm';
                Console.WriteLine(a.ToString());
                a.Pora();
                Console.WriteLine(a.ToString());
            }
        }
    }
}
