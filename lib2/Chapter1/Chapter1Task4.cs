using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    namespace Task4
    {
        abstract class Base
        {
            public abstract char symbol
            {
                get;
            }
            public abstract int this[int k]
            {
                get;
            }
            public abstract void show();
        }
        interface First
        {
            char symbol
            {
                get;
            }
            int this[int k]
            {
                get;
            }
            void show();
        }
        interface Second
        {
            char symbol
            {
                get;
            }
            int this[int k]
            {
                get;
            }
            void show();
        }
        class Myclass : Base, First, Second
        {
            private char smb;
            public Myclass(char s) : base()
            {
                smb = s;
            }
            public override char symbol
            {
                get
                {
                    return smb;
                }
            }
            char First.symbol
            {
                get
                {
                    return (char)(smb + 1);
                }
            }
            public override int this[int k]
            {
                get
                {
                    return smb + k;
                }
            }
            int Second.this[int k]
            {
                get
                {
                    return smb - k;
                }
            }
            public override void show()
            {
                Console.WriteLine("Базовый класс Base:\t\'{0}\'", symbol);
            }
            void First.show()
            {
                Console.WriteLine("Интерфейс First:\t\'{0}\'", symbol);
            }
            void Second.show()
            {
                Console.WriteLine("Интерфейс Second:\t\'{0}\'", symbol);
            }
        }
        class ExplInterfaceDemo
        {
            static void run()
            {
                Myclass obj = new Myclass('A');
                First A = obj;
                Second B = obj;
                obj.show();
                A.show();
                B.show();
                Console.WriteLine("obj.symbol=\'{0}'", obj.symbol);
                Console.WriteLine("A.symbol = \'{0}\'", A.symbol);
                Console.WriteLine("B.symbol = \'{0}\'", B.symbol);
                Console.WriteLine("obj[10]={0}", obj[10]);
                Console.WriteLine("A[10]={10}", A[10]);
                Console.WriteLine("B[10]={10}", B[10]);
            }
        }
    }
}
