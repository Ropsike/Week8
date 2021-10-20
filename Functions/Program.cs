using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string UserName2 = Console.ReadLine();
            Console.WriteLine("Sisesta oma vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            Greetings(UserName, UserName2, UserAge);
        }


        private static void Greetings(string someString, string UserName2, int UserAge)
        {
            Console.WriteLine($"Tere! {someString} {UserName2} ");
            Console.WriteLine($"Oled sündinud aastal {2021 - UserAge}.");
        }










    }
}
