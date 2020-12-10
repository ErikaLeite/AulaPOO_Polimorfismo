using System;
using AulaPOO_Polimorfismo.classes;

namespace AulaPOO_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan p1 = new MegaMan();

            string nomeP1 = "MegaMan";
            System.Console.WriteLine($"{nomeP1} está {p1.Correr()}");
            System.Console.WriteLine($"{nomeP1} está {p1.Pular()}\n");

            Zero p2 = new Zero();

            string nomeP2 = "Zero";
            System.Console.WriteLine($"{nomeP2} está {p2.Correr()}");
            System.Console.WriteLine($"{nomeP2} está {p2.Pular()}");
        }
    }
}
