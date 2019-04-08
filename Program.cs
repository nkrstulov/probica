using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19G3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Potrosnja> listPotr = new List<Potrosnja>();

            do
            {
                Console.WriteLine("1. Unos 2. Ispis");

                int odabir = int.Parse(Console.ReadLine());

                switch (odabir)
                {

                    case 1:
                        Console.WriteLine("Cijena kilovata?");
                        int cij = int.Parse(Console.ReadLine());
                        string odg;
                        do
                        {
                            Potrosnja potr = new Potrosnja(cij);
                            potr.Unos();

                            listPotr.Add(potr);
                            Console.WriteLine("Želite li još?");
                           odg = Console.ReadLine();
                        } while (odg=="da");
                        break;
                    case 2:
                        Console.WriteLine("Koji vremenski period zelite");
                        double vrem = double.Parse(Console.ReadLine());
                        try
                        {
                            if (vrem<=0)
                            {
                                throw new Iznimka("Vremenski period mora biti vći od 0")
;
                            }
                        }
                        catch (Iznimka iznimka)
                        {
                            Console.WriteLine(iznimka.Poruka);
                            Console.ReadLine();
                            break;
                        }
                        foreach (var item in listPotr)
                        {
                            item.Ispis(vrem);
                        }
                        break;

                    default:
                        break;
                }


            } while (true);
        }
    }
}
