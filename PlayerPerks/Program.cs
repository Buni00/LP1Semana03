using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerks = Perks.None;
            int wCounter = 0;
            int aCounter = 0;
            int sCounter = 0;
            int dCounter = 0;

            string perks = args[0];

            for (int i = 0; i< perks.Length; i++)
            {
                if(perks[i] == 'w')
                {
                    wCounter += 1;
                    if( wCounter % 2 != 0)
                    {
                        myPerks |= Perks.WaterBreathing;
                    }
                    if( wCounter % 2 == 0)
                    {
                        myPerks &= ~Perks.WaterBreathing;
                    }                  
                }

                if(perks[i] == 'a')
                {
                    aCounter += 1;
                    if( aCounter % 2 != 0)
                    {
                        myPerks |= Perks.Stealth;
                    }          
                    if( aCounter % 2 == 0)
                    {
                        myPerks &= ~Perks.Stealth;
                    }             
                }

                if(perks[i] == 's')
                {
                    sCounter += 1;
                    if( sCounter % 2 != 0)
                    {
                        myPerks |= Perks.AutoHeal;
                    }    
                    if( sCounter % 2 == 0)
                    {
                        myPerks &= ~Perks.AutoHeal;
                    }                   
                }

                if(perks[i] == 'd')
                {
                    dCounter += 1;
                    if( dCounter % 2 != 0)
                    {
                        myPerks |= Perks.DoubleJump;
                    }    
                    if( dCounter % 2 == 0)
                    {
                        myPerks &= ~Perks.DoubleJump;
                    }                   
                }

        
            }

            if ((myPerks & Perks.None)== Perks.None)
                Console.WriteLine("No perks at all!");

            Console.WriteLine(myPerks);
            

        }
    }
}
