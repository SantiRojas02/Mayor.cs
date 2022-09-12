using System;


namespace Mayor.cs
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.Write("Ingrese valor1: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese valor2: ");
            int valor1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese valor3: ");
            int valor2= Convert.ToInt32(Console.ReadLine());

            if (valor > valor1 && valor > valor2)
            {
                Console.WriteLine("El numero mayor es: " +valor);
            }
            else
            {
                if (valor1 > valor && valor1 > valor2)
                {
                    Console.WriteLine("El numero mayor es: " + valor1);
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + valor2);
                }
            }
            Console.ReadKey();
        }
    }
}
