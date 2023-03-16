using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerks;
            int wCounter = 0;
            int aCounter = 0;
            int sCounter = 0;
            int dCounter = 0;

            for (int i = 0; i< args.Length; i++)
            {
                if(args[i] == "w")
                {
                    wCounter += 1;
                    if( wCounter % 2 != 0)
                    {
                        myPerks = Perks.WaterBreathing;
                    }                  
                }

                if(args[i] == "a")
                {
                    aCounter += 1;
                    if( aCounter % 2 != 0)
                    {
                        myPerks = Perks.Stealth;
                    }                  
                }

                if(args[i] == "s")
                {
                    sCounter += 1;
                    if( sCounter % 2 != 0)
                    {
                        myPerks = Perks.AutoHeal;
                    }                  
                }

                if(args[i] == "d")
                {
                    dCounter += 1;
                    if( dCounter % 2 != 0)
                    {
                        myPerks = Perks.DoubleJump;
                    }                  
                }

                else
                {
                    Console.WriteLine("Unknown perk!");
                }
            }

            Console.WriteLine(myPerks);

        }
    }
}
