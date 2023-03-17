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

                if(wCounter % 2 != 0 || aCounter % 2 != 0 || sCounter % 2 != 0 || dCounter % 2 != 0 )
                {
                    myPerks &= ~Perks.None;
                }

                if (perks[i] != 'w' && perks[i] != 'a' && perks[i] != 's' && perks[i] != 'd')
                {
                    Console.WriteLine("Unknown perk!");
                    return;
                }
                    




        
            }

            if (myPerks !=0)
                Console.WriteLine(myPerks);

            if ((myPerks & Perks.None)== Perks.None)
            {
                Console.WriteLine("No perks at all!");

            }
                

            if (((myPerks & Perks.Stealth) == Perks.Stealth) & (myPerks & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");

            }
                
            
            
            

        }
    }
}
