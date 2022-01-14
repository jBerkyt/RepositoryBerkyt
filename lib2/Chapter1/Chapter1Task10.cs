using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    namespace Task10
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
                set;
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
        class MyClass : Base, First, Second
        {
            private char smb;
            public MyClass(char s) : base()
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
                set
                {

                }
            }
            int Second.this[int k]
            {
                get
                {
                    return smb - k;
                }
            }
            public override void show() { }
            void First.show() { }
            void Second.show() { }
        }
        class ExplInterfaceDemo
        {
            static void run()
            {
                MyClass obj = new MyClass('A');
                First A = obj;
                Second B = obj;
                obj.show();
                A.show();
                B.show();
                Console.WriteLine("obj.symbol=\'{0}\'", obj.symbol);
                Console.WriteLine("A.symbol=\'{0}\'", A.symbol);
                Console.WriteLine("B.symbol=\'{0}\'", B.symbol);
                Console.WriteLine("obj[10]={0}", obj[10]);
                Console.WriteLine("A[10]={0}", A[10]);
                Console.WriteLine("B[10]={0}", B[10]);

            }
        }
    }
   
}

       
