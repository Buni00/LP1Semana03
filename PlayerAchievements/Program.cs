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

            for ( int i = 0; i < n; i++)
            {
                Console.WriteLine($"O Jogador {i+1} tem o achievement 'DefeatOptionalBoss'? (s/n)");
                string resposta = Console.ReadLine();

                if( resposta == "s")
                {
                    myAchievements[i] |= Achievements.DefeatOptionalBoss;
                }


                Console.WriteLine($"O Jogador {i+1} tem o achievement 'FindHiddenLevel'? (s/n)");
                resposta = Console.ReadLine();

                if( resposta == "s")
                {
                    myAchievements[i] |= Achievements.FindHiddenLevel;
                }


                Console.WriteLine($"O Jogador {i+1} tem o achievement 'FinishGame'? (s/n)");
                resposta = Console.ReadLine();

                if( resposta == "s")
                {
                    myAchievements[i] |= Achievements.FinishGame;
                }
     
                
            }

            for ( int i = 0; i < n ; i++)
            {
                Console.WriteLine($"Achievements do Jogador {i+1}" +  $": {myAchievements[i]}");

                if(((myAchievements[i] & Achievements.DefeatOptionalBoss) == Achievements.DefeatOptionalBoss) & ((myAchievements[i] & Achievements.FindHiddenLevel) == Achievements.FindHiddenLevel) & ((myAchievements[i] & Achievements.FinishGame) == Achievements.FinishGame))
                    Console.WriteLine("Completionist");
            }
            

        }
    }
}
