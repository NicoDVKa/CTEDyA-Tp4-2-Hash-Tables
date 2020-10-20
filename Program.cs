using System;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable tabla1 = new HashTable(11);

            tabla1.insertarHA(5);
            tabla1.insertarHA(20);
            tabla1.insertarHA(3);
            tabla1.insertarHA(1000);
            tabla1.insertarHA(45);
            tabla1.insertarHA(27);
            tabla1.insertarHA(25);

            tabla1.verHA();




            Console.ReadKey(true);

        }

        static public int hash(int x) //Funcion de hash especifica para este problema
        {
            return x % 11;
        }
    }
}
