using System;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejer1();
            Console.ReadKey();
        }

        static void Ejer1()
        {
            string nombre,carrera; //declarando variables

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido a FA de {carrera}");

        }

       

    }
