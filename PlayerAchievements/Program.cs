using System;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos jogadores são: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Achievements[] myAchievements = new Achievements[n];

            for ( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Quais são os achievements do Jogador {i}");
                
            }

        }
    }
}
