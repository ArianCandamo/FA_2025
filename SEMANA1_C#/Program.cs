using System;
using System.Text.RegularExpressions;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey();
        }

        static void ejer1()
        {
            string nombre, carrera; //declarando variables

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido a FA de {carrera}");

        }

        static void ejer2()
        {
            Console.Write("\"Arian\"");
            
            
        }

        static void ejer3()
        {
            Console.Write("Ingrese numero x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero y: ");
            int y = int.Parse(Console.ReadLine());

            double resu = x / y;

            Console.WriteLine("Suma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + resu);
        }

        static void ejer4()
        {
            Console.Write("Ingrese un numero decimal: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num,0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1/3d);

            Console.WriteLine("Raiz 2: " + raiz2);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raiz 3: " + raiz3);
        }

        static void ejer5()
        {
            Console.Write("Ingrese su numero: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("Resto: " + (entero % 2));
            Console.WriteLine("Division: " + (deci / 3));
        }
    }


}