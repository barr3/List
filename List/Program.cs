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

        static void showData()
        {
            Console.Clear();
            for (int j = 0; j < kontakter.Count; j++)
            {
                kontakter[j].showData();
            }

            Console.WriteLine("Tryck 1 om du vill ändra någon kontakt");

            /*if (Console.ReadLine )
            {

            }*/

        }
    }
}
