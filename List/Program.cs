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

            Console.WriteLine("Tryck 1 om du vill lägga till en till kontakt");
            if (Console.ReadLine() == "1")
            {
                return true;
            }
            else
            {
                return false;
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
                Console.WriteLine($"Kontakt nr {j+1}");
                
                kontakter[j].showData();
            }

            Console.WriteLine("Tryck 1 om du vill ändra någon kontakt");

            if (Console.ReadLine() == "1" )
            {
                Console.WriteLine("Vilken?");
                
                ändraKontakt(int.Parse(Console.ReadLine()));
            }

        }
    }
}
