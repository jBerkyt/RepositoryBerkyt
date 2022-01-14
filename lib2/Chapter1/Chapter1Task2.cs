using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    namespace Task2
    {
        abstract class Base
        {
            protected String str = "";

            public Base(String str)
            {
                this.str = str;
            }

            public abstract int qwe
            {
                get;
            }

            abstract public int this[int i]
            {
                get;
            }

            abstract public void method1();

            abstract public void method1(String str);
        }
        class CBase : Base
        {
            public CBase(String str) : base(str)
            {

            }

            public override int qwe
            {
                get
                {
                    return str.Length;
                }
            }

            public override int this[int i]
            {
                get
                {
                    return (int)str[i];
                }
            }

            public override void method1(String str)
            {
                this.str = str;
            }

            public override void method1()
            {
                Console.WriteLine("Значение поля:\t{0}", str);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                CBase main = new CBase("Привет Генка Михайло!");

                main.method1();

                Console.WriteLine("Индекс:\t\t{0}", main[0]);

                Console.WriteLine("Свойство:\t{0}", main.qwe);
            }
        }
    }
}
