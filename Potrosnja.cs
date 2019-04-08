using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19G3
{
    class Potrosnja
    {
        public string NazivUredaja { get; set; }
        public int PostotakRada { get; set; }
        public double Kilovati { get; set; }
        public static int Cijena { get; set; }

        public Potrosnja(int cijena)
        {
            Cijena = cijena;
        }

        public void Unos()
        {
            Console.WriteLine("Unesite naziv uredaja");
            NazivUredaja = Console.ReadLine();
            Console.WriteLine("Koliko posto dana radi");
            PostotakRada = int.Parse(Console.ReadLine());
            Console.WriteLine("Koliko kilovata trosi");
            Kilovati = double.Parse(Console.ReadLine());

        }
        public void Ispis(double vrem)
        {
           
            //kilovatsat nor 10 kn
            double KolikoRadiMjesecno=0;
            double KolikoSatiRadiDnevno = ((double)PostotakRada / 100) * 24;  
           // double potr = 0;

            for (int i = 0; i < vrem*30; i++)
            {

                KolikoRadiMjesecno += KolikoSatiRadiDnevno; //koliko sati radi mjesecno
            }

            double potrosnja = Kilovati * KolikoRadiMjesecno *Cijena ;



            Console.WriteLine("Ovaj uređaj, {0}, potroši {1} kuna u {2} mjeseca.", NazivUredaja, potrosnja , vrem );

        }


    }
}
