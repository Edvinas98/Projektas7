using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas7.Models;

namespace Projektas7
{
    internal class OOP
    {
        static void Main(string[] args)
        {
            //PirmojiUzduotis();

            //AntrojiUzduotis
            
            //TreciojiUzduotis();

            //KetvirtojiUzduotis();

            //PenktojiUzduotis();
        }

        /// <summary>
        /// Sukuria objekta Automobilis su pateikiamais duomenimis: marke ir metai
        /// </summary>
        static void PirmojiUzduotis()
        {
            Automobilis auto = new Automobilis("BMW", 2012);
            Console.WriteLine(auto);
        }

        /// <summary>
        /// Patikrina, ar vartotojas yra nepilnametis, pilnametis ar senjoras pagal ivesta amziu.
        /// </summary>
        static void AntrojiUzduotis()
        {
            Console.WriteLine("Iveskite savo amziu:");
            if (!int.TryParse(Console.ReadLine(), out int amzius) && amzius >= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            if(amzius < 18)
                Console.WriteLine("Jus esate nepilnametis");
            else if(amzius < 75)
                Console.WriteLine("Jus esate pilnametis");
            else
                Console.WriteLine("Jus esate senjoras");
        }

        /// <summary>
        /// Sukuria sveikuju skaiciu masyva su skaiciais 1-10 ir ji atspausdina naudojant for cikla
        /// </summary>
        static void TreciojiUzduotis()
        {
            int[] masyvas = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for(int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine(masyvas[i]);
            }
        }

        /// <summary>
        /// Sukuria sveikuju skaiciu masyva su skaiciais 1-5 ir ji atspausdina naudojant while cikla
        /// </summary>
        static void KetvirtojiUzduotis()
        {
            int[] masyvas = new int[5] { 1, 2, 3, 4, 5 };

            int i = 0;
            while(i < masyvas.Length)
            {
                Console.WriteLine(masyvas[i]);
                i++;
            }
        }

        /// <summary>
        /// Nuskaito vartotojo pateiktus duomenis: studento vardas ir pazymys
        /// Sukuria objekta Studentas su duomenimis: vardas ir pazymys
        /// Patikrina ar pazymys yra 5 ar didesnis ir atspausdina rezultata
        /// </summary>
        static void PenktojiUzduotis()
        {
            Console.WriteLine("Iveskite studento varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pazymi:");
            if (!int.TryParse(Console.ReadLine(), out int pazymys) && pazymys >= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Studentas studentas = new Studentas(vardas, pazymys);
            if(studentas.CheckArIslaike())
                Console.WriteLine($"{studentas.Vardas} egzamina islaike");
            else
                Console.WriteLine($"{studentas.Vardas} egzamino neislaike");
        }
    }
}
