using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    namespace Task8
    {
        interface First_Interface
        {
            String text
            {
                get;
            }
        }

        // 2-ой интерфейс---------------------------------------------------------------------------------------------------------------
        interface Second_Interface
        {
            String text
            {
                get;
            }
        }

        // 1-ый класс-------------------------------------------------------------------------------------------------------------------
        class First_Class : First_Interface
        {
            private String txt;

            // Конструктор класса
            public First_Class(String txt)
            {
                this.txt = txt;
            }

            // Неявное описание свойства из интерфейса
            public String text
            {
                get
                {
                    return txt;
                }
            }

            // Явное описание свойства интерфейса
            String First_Interface.text
            {
                get
                {
                    return txt;
                }
            }
        }

        // 2-ой класс--------------------------------------------------------------------------------------------------------------------
        class Second_Class : Second_Interface
        {
            private String txt;

            // Конструктор класса
            public Second_Class(String txt)
            {
                this.txt = txt;
            }

            // Неявное описание свойства из интерфейса
            public String text
            {
                get
                {
                    return txt;
                }
            }

            // Явное описание свойства интерфейса
            String Second_Interface.text
            {
                get
                {
                    return txt;
                }
            }
        }
        class InterfaceClass
        {
            static void Main()
            {
                String txt = Console.ReadLine();

                First_Class A = new First_Class(txt);
                Second_Class B = new Second_Class(txt);

                // Реализация свойства
                Console.WriteLine("\n");
                Console.WriteLine(A.text);
                Console.WriteLine("\n");
                Console.WriteLine(B.text);
                Console.WriteLine("\n");

            }
        }
    }
}
