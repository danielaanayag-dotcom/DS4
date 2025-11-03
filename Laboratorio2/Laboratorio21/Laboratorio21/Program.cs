using System;

namespace Laboratorio21
{
    public class Program
    {
        public static void Main()
        {
            //Asignado valor a variable estatica.
            MyClass.valor = 1;
            Console.WriteLine(MyClass.valor);
        }
    }
    public class MyClass
    {
        //Declarando variable estatica
        public static int valor;
    }
}