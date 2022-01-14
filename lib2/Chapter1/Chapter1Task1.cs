using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    namespace Task1
    {
        abstract class Base
        {
            protected int[] arr;
            public Base(int d)
            {
                arr = new int[d];
                for (int i = 0; i < d; i++)
                {
                    arr[i] = 0;
                }
            }
            public int dimm
            {
                get
                {
                    return arr.Length;
                }
            }
            abstract public void abs();
            abstract public int this[int i]
            {
                get;
                set;
            }
        }
        class Chi1 : Base
        {
            public Chi1(int d) : base(d) { }

            public override void abs()
            {
                for (int i = 0; i < dimm; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
            }
            public override int this[int i]
            {
                get
                {
                    return arr[i];
                }
                set
                {
                    arr[i] = value;
                }
            }
        }

        namespace _1
        {
            public class Program
            {
                public static void run(string[] args)
                {
                    Chi1 e = new Chi1(5);
                    e.abs();
                    e[0] = 0;
                    e[1] = 1;
                    e[2] = 2;
                    e[3] = 3;
                    e[4] = 4;
                    e.abs();
                    Console.Read();
                }
            }
        }

    }
}
