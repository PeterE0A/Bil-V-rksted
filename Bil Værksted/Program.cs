using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_Værksted
{
    public struct Program
    {

        static void Main(string[] args)
        {
            string[] Fiat = { "fiat", "ponto", "01/01/2010" };
            string[] AlfaRomeo = { "alfa romeo", "giulia", "01/08/2019" };

            int i = 1;

            while (i == 1)
            {




                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                Console.SetCursorPosition(45, 7);
                Console.Write("---------- Bil ----------");

                Console.SetCursorPosition(45, 10);
                Console.Write("Mærke: ");
                string mærke = Convert.ToString(Console.ReadLine());

                Console.SetCursorPosition(45, 12);
                Console.Write("Model: ");
                string model = Convert.ToString(Console.ReadLine());

                Console.SetCursorPosition(45, 14);
                Console.Write("Årgang: ");
                int årgang = Convert.ToInt32(Console.ReadLine());

                Console.SetCursorPosition(45, 16);
                Console.Write("Sidst Synet i dd/mm/yyyy Format: ");
                DateTime synet = DateTime.Parse(Console.ReadLine());
                DateTime expirationDate = DateTime.Parse("1/12/2024");

                if (synet.Date == expirationDate.Date || synet.Date > expirationDate.Date)
                {

                    Console.SetCursorPosition(45, 18);
                    Console.WriteLine("Bilen skal til syn");
                    Console.ReadLine();
                }
                else
                {
                    Console.SetCursorPosition(45, 18);
                    Console.WriteLine("Bilen skal ikke synes");
                    Console.ReadLine();
                }

                if (mærke == Fiat[0])
                {
                    Console.SetCursorPosition(45, 20);
                    Console.WriteLine("Bilen har følgende fabriksfejl: Udstødning");
                    Console.ReadLine();
                }
                else if (mærke == AlfaRomeo[0])
                {
                    Console.SetCursorPosition(45, 20);
                    Console.WriteLine("Bilen har følgende fabriksfejl: Styrtøjet");
                    Console.ReadLine();
                }


            }



            Console.ReadKey();
        }
    }
}
