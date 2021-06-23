using System;

namespace MultiplosDe13_URI1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            int menor = x;
            int maior = y;

            //Verifica as condições entre maior e menor.
            if (x > y)
            {
                menor = y;
                maior = x;
            }

                int total = 0;
           
                //Calcula os valores um a um 
                for (int i = menor; i <= maior; i++)
                {

                    //Verifica os valores que não são divisíveis por 13
                    if (i % 13 != 0)
                    {
                    total = total + i;
                    }                    
                }

            Console.WriteLine(total);

        }
    }
}
