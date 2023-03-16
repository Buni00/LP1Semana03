using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a dimensão horizontal:");
            int horizontal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a dimensão vertical:");
            int vertical =Convert.ToInt32( Console.ReadLine());

            float [ , ] matrix = new float [horizontal, vertical];


            for ( int i = 0; i < matrix.GetLength(0); i ++)
            {
                for (int j = 0; j < matrix.GetLength(1); j ++)
                {
                    Console.WriteLine($"valor na posição ({i},{j}): ");
                    float valor = float.Parse(Console.ReadLine());

                    matrix[i , j] = valor;    
                }
            }

            for ( int i = 0; i < matrix.GetLength(0); i ++)
            {       

                float somaLinha = 0f;
    
                for (int j = 0; j < matrix.GetLength(1); j ++)
                {

                    somaLinha += matrix [i,j];
                    
                }

                Console.WriteLine($"Na linha {i+1} a soma dos seus valores é: {somaLinha}");
                
            }

            for ( int i = 0; i < matrix.GetLength(0); i ++)
            {       
                float somaColuna = 0f;

                for (int j = 0; j < matrix.GetLength(1); j ++)
                {

                    somaColuna += matrix [j,i];
                    
                }

                Console.WriteLine($"Na coluna {i+1} a soma dos seus valores é: {somaColuna}");
                
            }


            

        }
    }
}
