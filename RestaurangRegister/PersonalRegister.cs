using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurangRegister
{
    internal class PersonalRegister
    {
        public static void MenyText()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Menyval Restaurangregistret");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("1: Registrera ny");
            Console.WriteLine("2: Se registret");
            Console.WriteLine("3: Avsluta");
            Console.Write("Skriv ert val: ");
            Console.WriteLine();
        }

        public static void PersonalInmatning()
        {
            Console.Write("Skriv in namn: ");
            string firstName = Console.ReadLine();

            Console.Write("Skriv in lön: ");
            string salary = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Uppgifterna är tillagda.");
            Console.WriteLine();
        }
    }
}

