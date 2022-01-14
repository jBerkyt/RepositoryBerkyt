using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    namespace Task9
    {
        delegate double MyDelegate(double x);

        class Program
        {
            static MyDelegate method(double a, double b, double c)
            {
                return x => a * x * x + b * x + c;
            }
            static int run()
            {
                Console.WriteLine(method(1, 2, 3)(10));
                return 0;
            }
        }
    }
}
