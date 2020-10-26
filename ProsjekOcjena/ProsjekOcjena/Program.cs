using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjena
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            float brojOcjena = 0;
            float zbrojOcjena = 0;
            string uputa = "Upisi ocjenu: ";
            string ispis = "Prosjek je: ";
            float prosjek;

            do
            {
                Console.Write(uputa);
                ocjena = Convert.ToInt32(Console.ReadLine());
                if (ocjena >= 1 || ocjena <= 5)
                {

                    brojOcjena++;
                    zbrojOcjena += ocjena;
                }
                else if (ocjena == 0)
                {
                    prosjek = zbrojOcjena / brojOcjena;
                    Console.Write(ispis);
                    Console.Write(prosjek);
                }
            }

            while (ocjena != 0);

            Console.ReadKey();


        }
    }
}
