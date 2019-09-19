using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            int ganzezahl = 16557;
            double gleitkommaZahl = 168.246;
            char Zeichen = ']';
            bool wahrheitswert = true;
            // Console.WriteLine(message+Environment.NewLine+ganzezahl);
            //Console.WriteLine(message + "\r\n" + ganzezahl) ;
            //Console.WriteLine(ganzezahl);
            //Console.WriteLine(gleitkommaZahl);
            //Console.WriteLine(Zeichen);
            //Console.WriteLine(wahrheitswert);

            // for (int i = 1; i <= 10; i++)
            //{
            //  Console.WriteLine(i+" ");
            //}
            int zahl1,zahl2;
            Console.WriteLine("Eine ganze Zahl eingeben:");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eine weitere ganze Zahl eingeben:");
            zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Die Produkt ist " + zahl1*zahl2);
        }
    }
}
