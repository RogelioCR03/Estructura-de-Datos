using System;

namespace Proyecto_Calculo_Vectorial
{

    class Program
    {
        public static int i;
        public static int j;
        public static int k;
        public static int operacion;
        public static double MAGNITUD;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            SumaDeVectores();
        }
        public static void SumaDeVectores() 
        {
            Console.WriteLine("Vector A: ");
            Console.WriteLine("Valor de i: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de j: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de k: ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("\nVector B: ");
            Console.WriteLine("Valor de i: ");
            int I = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de j: ");
            int J = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de k: ");
            int K = int.Parse(Console.ReadLine());

            Console.WriteLine("                   |{0}|", I+i);
            Console.WriteLine("Vector Resultante: |{0}|", J+j);
            Console.WriteLine("                   |{0}|", K+k);
        }
        public static void PorUnEscalar() 
        {
            Console.WriteLine("Valor de i: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de j: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de k: ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor del escalar: ");
            int escalar = int.Parse(Console.ReadLine());

            int I = i * escalar;
            int J = j * escalar;
            int K = k * escalar;

            Console.WriteLine("                   |{0}|", I);
            Console.WriteLine("Vector Resultante: |{0}|", J);
            Console.WriteLine("                   |{0}|", K);

        }
        public static void Magnitud(ref int operacion) 
        {
            Console.WriteLine("Valor de i: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de j: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de k: ");
            k = int.Parse(Console.ReadLine());
            int I = i * i;
            int J = j * j;
            int K = k * k;

            operacion = I + J + K;
            MAGNITUD = Math.Sqrt(operacion);
            Console.WriteLine("                      ____");
            Console.WriteLine("Magnitud del vector: √{0} ", operacion);

        }
    }
}
