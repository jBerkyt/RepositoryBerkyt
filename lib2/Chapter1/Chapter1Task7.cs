using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    namespace Task7
    {
        interface Alpha
        {
            int num { get; set; }
            void get();
        }
        interface Bravo
        {

            string text { get; set; }
            void get();
        }
        class Delta : Alpha, Bravo
        {
            int i; string s;
            public void setI(int n) { i = n; }
            public void setS(string x) { s = x; }
            public int num
            {
                get
                {
                    return i;
                }
                set { setI(value); }
            }
            public string text
            {
                get
                {
                    return s;
                }
                set { setS(value); }
            }
            public void get()
            {
                Console.WriteLine(num);
                Console.WriteLine(text);

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Delta x = new Delta();
                x.text = "ljnmojimolkm";
                x.num = 555555555;
                x.get();


            }
        }
    }
}
