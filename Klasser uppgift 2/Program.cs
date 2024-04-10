using Klasser_uppgift_2;
using System;

namespace Uppgift2
{
    class Program
    {
        static void Main()
        {
            Namn namn2 = new("Ernst", "Osbeck", new DateTime(2006, 03, 10), 75, 185);
            Console.WriteLine("Namn: " + namn2.SetNamn);
            Console.WriteLine("Födelsedag: " + namn2.setDatum);
            Console.WriteLine("Myndig: " + namn2.KontrolleraDatum());
            Console.WriteLine("BMI: " + namn2.BMI());
        }
    }
}