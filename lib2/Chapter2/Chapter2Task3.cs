using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    namespace Task3
    {
        delegate char Del();
        class MyClass
        {
            public string _text;
            private Del _del;
            public Del DelProperty => _del;
            public MyClass(string text, bool b)
            {
                _text = text;
                if (b)
                {
                    _del = () => text[0];
                }
                else
                {
                    _del = () => text[text.Length - 1];
                }
            }
        }
        class Program
        {
            static void run(string[] args)
            {
                var A = new MyClass("Hello", true);
                var B = new MyClass("Hello", false);
                Console.WriteLine(A.DelProperty());
                Console.WriteLine(B.DelProperty());
            }
        }
    }
}
