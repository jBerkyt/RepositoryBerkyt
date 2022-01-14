using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3

{
    namespace Task2
    {
        struct show
        {
            int a;
            string b;
            char c;
            public show(int a, string b, char c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public show(int a, string b)
            {
                this.a = a;
                this.b = b;
                c = ' ';
            }
            public show(string b)
            {
                this.b = b;
                a = 0;
                c = ' ';
            }
            public void print()
            {
                Console.WriteLine("a: " + a + " b: " + b + " c: " + c);
            }
        }
    }
}

