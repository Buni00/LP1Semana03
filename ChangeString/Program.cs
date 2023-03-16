using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Escreva uma letra:");
            string letra = Console.ReadLine();

            int letraConvert = Convert.ToInt32(letra[0]);
            
            for(int i = 0 ; i<frase.Length ; i++ )
            {
                int fraseConvert = Convert.ToInt32(frase[i]);
                
                if (fraseConvert != letraConvert)
                {
                    Console.Write(frase[i]);
                }
            }

    
        }
    }
}
