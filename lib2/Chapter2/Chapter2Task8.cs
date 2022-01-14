using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    namespace Task8
    {
        delegate int D(int a);
        class zadacha
        {
            public static D ObeMe(D a, D b)
            {
                return n =>
                {
                    return b(a(n));
                };
            }
        }
        class Proverca
        {
            public void Prove()
            {
                if (zadacha.ObeMe(n => { return n + 1; }, t => { return t + 2; })(7) == 10)
                {
                    Console.WriteLine("Метод работает верно");
                }
                else
                {
                    Console.WriteLine("Метод работает не верно");
                }
            }
        }
        class main
        {
            static void run(string[] args)
            {
                D m;
                Proverca a = new Proverca();
                m = zadacha.ObeMe(c => { return c + 1; }, k => { return k + 2; });
                Console.WriteLine(m(7));
                a.Prove();
            }
        }
    }
}
