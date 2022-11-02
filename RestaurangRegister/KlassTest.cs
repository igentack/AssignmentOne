using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurangRegister
{
    internal class KlassTest
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
            Console.WriteLine();
            Console.Write("Skriv ert val: ");
        }

        public static void PersonalInmatning()
        {
            Console.Write("Skriv in namn: ");
            string firstName = Console.ReadLine();

            Console.Write("Skriv in lön: ");
            string salary = Console.ReadLine();

            string[] kundUppgift = { "Namn. " + firstName + "Lön: " + salary };
            regArray.Add(kundUppgift);
            Console.WriteLine();
            Console.WriteLine("Uppgifterna är tillagda.");
            Console.WriteLine();
        }
    }
}

