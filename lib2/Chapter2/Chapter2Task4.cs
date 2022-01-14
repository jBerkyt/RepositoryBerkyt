using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    namespace Task4
    {
        delegate int MyDelegate(int n);
        class MyClass
        {
            public int Method(int value)
            {
                return 0;
            }
        }
        class Base
        {
            private MyDelegate a;
            public Base(int value)
            {
                MyClass m = new MyClass(); ;
                //a = m.Method;
                a = new MyDelegate(m.Method);
            }
            public MyDelegate this[int k]
            {
                get
                {

                    return a;
                }
            }
        }
        class Program
        {
            static void run()
            {
                int k = 3;
                int n = 4;
                Base obj = new Base(n);
                Console.WriteLine(obj[k](n));
            }
        }

    }
}
