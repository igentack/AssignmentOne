using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace RestaurangRegister
{
    // Uppgift 1: Vet inte, antar att min Registerklass bör ingå. 

    // Uppgift 2: Kan ej OOP så vet inte exakt hur ni menar, fall det är meningen att det skall ärvas osv.
    //     Metoder bör iaf vara Write och ReadLine metoder, samt en metod som räknar.

    //     Medveten om att detta kanske inte är så bra beskrivet (ovan), men jag kommer försöka lära
    //     mig det i detta program...
    //     
    //     *** Blev även varse om att jag inte kan C# (samt nomenklaturen) något alls :( ***

    
    internal class Register 
    {    
        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                ArrayList regArray = new ArrayList();
                
                Console.WriteLine("Välkommen till Restaurangregistret");
                Console.WriteLine("----");
                Console.WriteLine("Registrera ny 1: ");
                Console.WriteLine("Se registret 2: ");
                Console.WriteLine("Avsluta 3: ");

                string val = Console.ReadLine();

                if (val == "1")
                {

                    Console.WriteLine("Skriv in namn: ");
                    string firstName = Console.ReadLine();
                    regArray.Add(firstName);
                    Console.WriteLine("Skriv in lön: ");
                    string salary = Console.ReadLine();
                    regArray.Add(Tuple.Create(firstName, salary));


                }

                if (val == "2")
                {
                    foreach (Tuple<string, string> tuple in regArray)
                    {
                        Console.WriteLine(tuple.Item1 + ".");
                    }
                    Console.ReadLine();
                }

                if (val == "3")
                {
                    Console.WriteLine("Trevlig dag!");
                    loop = false; 
                }
                Console.ReadLine();
            } while (loop);
        }
    }
}