using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Kontakt
    {

        private string namn;
        private string telefonNummer;
        private int födelseÅr;


        /*public Kontakt()
        {
            
        }*/

        public void showData()
        {
            Console.WriteLine("Namn: " + namn);
            Console.WriteLine("Telefonnummer: " + telefonNummer);
            Console.WriteLine("Födelseår: " + födelseÅr);
            Console.Write("\n\n");


        }

        public string getNamn()
        {
            return namn;
        }

        public void setNamn(string namn)
        {
            this.namn = namn;
        }

        public string getNummer()
        {
            return telefonNummer;
        }

        public void setNummer(string telefonNummer)
        {
            this.telefonNummer = telefonNummer;
        }

        public int getFödelseÅr()
        {
            return födelseÅr;
        }

        public void setFödelseÅr(int födelseÅr)
        {
            this.födelseÅr = födelseÅr;
        }

    }
}
