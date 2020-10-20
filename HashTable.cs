using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class HashTable
    {
        private int tamaño;
        private ArrayList[] tablaHA;//Dispersion abierta
        private int[] tablaHC;//Dispersion cerrada

        public HashTable(int tamaño)
        {
            this.tamaño = tamaño;
            this.tablaHA = new ArrayList[tamaño]; 
            this.tablaHC= new int[tamaño];
        }

        //Dispersion abierta

        public void insertarHA(int num)
        {
            int clave = num % tamaño; //Funcion de hash

            if (tablaHA[clave]==null)
            {
                tablaHA[clave] = new ArrayList();
                tablaHA[clave].Add(num);
            }
            else
            {
                tablaHA[clave].Add(num);
            }
        }

        public void verHA()
        {
            for (int i=0; i<tamaño;i++)
            {
                Console.WriteLine("En la posicion {0}:",i);
                if (this.tablaHA[i]!=null)
                {
                    foreach (int x in this.tablaHA[i])
                    {
                        Console.WriteLine(x);
                    }
                }
            }
        }


        //Dispersion cerrada

    }
}
