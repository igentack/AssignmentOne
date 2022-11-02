using System.Collections;
namespace RestaurangRegister
{
    internal class Register 
    {    
        static void Main(string[] args)
        {
            bool loop = true;
            ArrayList regArray = new ArrayList();
            do
            {           
                KlassTest.MenyText();
              /*  Console.WriteLine("Välkommen till Restaurangregistret");
                Console.WriteLine("----");
                Console.WriteLine("Registrera ny 1: ");
                Console.WriteLine("Se registret 2: ");
                Console.WriteLine("Avsluta 3: ");*/

                string val = Console.ReadLine();

                if (val == "1")
                {
                 /*   Console.Write("Skriv in namn: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Skriv in lön: ");
                    string salary = Console.ReadLine();

                    string[] kundUppgift = { "Namn. " + firstName + "Lön: " + salary };
                    regArray.Add(kundUppgift);
                    Console.WriteLine();
                    Console.WriteLine("Uppgifterna är tillagda.");
                    Console.WriteLine();*/
                    continue;
                }

                else if (val == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Personal:");
                    Console.WriteLine(regArray.Count);
                    Console.WriteLine();
                    continue;
                    /*      foreach (var item in regArray)
                          {
                              Console.WriteLine(item);
                          }
                          Console.ReadLine();*/
                }

                else if (val == "3")
                {
                    Console.WriteLine("Trevlig dag!");
                    loop = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("OBS! - Ni måste välja alt. 1, 2 eller 3.");
                    Console.WriteLine();
                    continue;
                }
                Console.ReadLine();
            } while (loop);
        }
    }
}