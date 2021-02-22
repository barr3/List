using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static List<Kontakt> kontakter = new List<Kontakt>();

        static void Main(string[] args)
        {


            inputKontakt();

            showData();

            Console.ReadLine();

        }

        static bool skapaKontakt(int i)
        {
            Console.Clear();
            kontakter.Add(new Kontakt());
            
            Console.WriteLine("Vänligen ange namn på kontakten.");
            kontakter[i].setNamn(Console.ReadLine());

            Console.WriteLine("\nVänligen ange " + kontakter[i].getNamn() + "s telefonnummer.");
            kontakter[i].setNummer(Console.ReadLine());

            Console.WriteLine("\nVänligen ange " + kontakter[i].getNamn() + "s födelseår.");
            kontakter[i].setFödelseÅr(int.Parse(Console.ReadLine()));

            while (true)
            {
                Console.WriteLine("While loop");
                Console.WriteLine("Vill du lägga till ytterligare en kontakt (j/n)");
                string input = Console.ReadLine().ToLower();
                if (input == "j")
                {
                    return true;
                }
                else if(input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Vänligen ange ett av alternativen\n");
                }

            }

        }

        static void inputKontakt()
        {
            int i = 0;
            while (true)
            {
                if (skapaKontakt(i) == false)
                {
                    break;
                }

                i++;
            }
        }
        static void ändraKontakt(int index)
        {
            index -= 1;
            Console.WriteLine("Vad vill du ändra?");
            Console.WriteLine("1: Namn");
            Console.WriteLine("2: Telefonnummer");
            Console.WriteLine("3: Födelseår");

            int change = int.Parse(Console.ReadLine());

            

            switch (change)
            {
                case 1:
                    Console.WriteLine("Vad vill du sätta för namn?");
                    kontakter[index].setNamn(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Vad vill du sätta för telefonnummer?");
                    kontakter[index].setNummer(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Vad vill du sätta för födelseår?");
                    kontakter[index].setFödelseÅr(int.Parse(Console.ReadLine()));
                    break;
                default:
                    break;
            }

            showData();

        }

        static void showData()
        {
            Console.Clear();
            for (int j = 0; j < kontakter.Count; j++)
            {
                Console.WriteLine($"Kontakt nr {j + 1}");

                kontakter[j].showData();
            }

            Console.WriteLine("Vill du ändra någon kontakt eller ? j/n");
            string input = Console.ReadLine().ToLower();

            if (input == "j")
            {

                int kontaktNr;

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Vilken kontakt vill du ändra?");
                        kontaktNr = int.Parse(Console.ReadLine());

                        if (kontaktNr <= kontakter.Count)
                        {
                            break;
                        }


                        
                    }
                    catch
                    {
                        Console.WriteLine("Vänligen välj en kontakt som finns");
                    }

                }

                Console.WriteLine(kontaktNr);

                ändraKontakt(kontaktNr);
            }

            else if (input == "n")
            {

            }
            else
            {
                Console.WriteLine("Vänligen skriv j/n");
            }

        }
    }
}
