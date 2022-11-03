using System.Collections;
namespace RestaurangRegister
{
    internal class Register 
    {    
        static void Main(string[] args)
        {
            Personal personal = new Personal(firstName: "Förnamn", lastName: "Efternamn", salary: "Lön");
            bool loop = true;
          
            do
            {           
                PersonalRegister.MenyText();
     
                string val = Console.ReadLine();

                if (val == "1")
                {
                    Console.Write("Skriv in namn: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Skriv in lön: ");
                    string salary = Console.ReadLine();

           
                    Console.WriteLine();
                    Console.WriteLine("Uppgifterna är tillagda.");
                    Console.WriteLine();
                    continue;
                }

                else if (val == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Personal:");
                 
                    Console.WriteLine();
                    continue;
                    //foreach (var item in regArray)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    //Console.ReadLine();
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