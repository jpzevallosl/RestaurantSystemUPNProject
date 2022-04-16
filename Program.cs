using System;

using System.Collections;

using System.Linq;

using System.Text;





namespace P5pilas

{

    internal class Program

    {

        public static int sumaNodos(IEnumerable myCollection)

        {

            int suma = 0;



            foreach (Object obj in myCollection)

                suma = suma + int.Parse(string.Format("{0}", obj));

            return suma;

        }



        public static void Main()

        {

            Stack p5Pila = new Stack();

            p5Pila.Push(5);

            p5Pila.Pop();

            p5Pila.Push(3);

            p5Pila.Pop();

            p5Pila.Push(7);

            p5Pila.Push(3);

            p5Pila.Push(1);





            Console.Write("La suma de los datos de la pila es: " + sumaNodos(p5Pila) + " ");

        }

    }

}