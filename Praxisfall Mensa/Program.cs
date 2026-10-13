using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Praxisfall_Mensa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string artikelname1;
            string artikelname2;
            decimal einzelpreis1;
            decimal einzelpreis2;
            int menge1;
            int menge2;
            decimal mengenpreis1;
            decimal mengenpreis2;
            decimal gesamtpreis;

            
            Console.WriteLine("\nerster Artikelname eingeben:");
            artikelname1 = Console.ReadLine();
            Console.WriteLine("\nPreis eigeben:");
            einzelpreis1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nMenge eingeben:");
            
            
            menge1 = Convert.ToInt32(Console.ReadLine());
            
            mengenpreis1 = menge1 * einzelpreis1;
            
            //Console.WriteLine("Mengenpreis: " + mengenpreis1);

            Console.WriteLine("\n\nzweiter Artikelname eingeben:");
            artikelname2 = Console.ReadLine();
            Console.WriteLine("\nPreis eigeben:");
            einzelpreis2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nMenge eingeben:");
            menge2 = Convert.ToInt32(Console.ReadLine());

            mengenpreis2 = menge2 * einzelpreis2;

            //Console.WriteLine("Mengenpreis: " + mengenpreis1);


            if (menge1 < 1)
            {

                Console.WriteLine("Ungültige Eingabe");
            }
            else {
                if (menge1 > 2 &&  menge1 < 5)
                {
                    menge1 = menge1 / 10 * 9;
                }

                if (menge1 > 4)
                {
                    menge1 = menge1 / 10 * 8;
                }

            }


            if (menge2 < 1)
            {

                Console.WriteLine("Ungültige Eingabe");
            }
            else
            {
                if (menge2 > 2 && menge2 < 5)
                {
                    menge2 = menge2 / 10 * 9;
                }

                if (menge2 > 4)
                {
                    menge2 = menge2 / 10 * 8;
                }

            }

            gesamtpreis = mengenpreis1 + mengenpreis2;
            Console.WriteLine("\n\n" + artikelname1 + ": " + einzelpreis1 + "CHF | " + menge1 + " | " + mengenpreis1 +"CHF\n" + artikelname2 + ": " + einzelpreis2 + "CHF | " + menge2 +" | "+ mengenpreis2 + "CHF\nGesamtpreis: " + gesamtpreis + "CHF");

            Console.ReadLine();



        }
    }
}
