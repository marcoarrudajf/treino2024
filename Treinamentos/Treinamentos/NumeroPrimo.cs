using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class NumeroPrimo
    {
        public void numPrimos()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int res = 0;
                int valor = int.Parse(Console.ReadLine());
                for (int j = 1; j <= valor; j++)
                {
                    if (valor % j == 0)
                    {
                        res++;
                    }
                }
                if (res <= 2)
                {
                    Console.WriteLine($"{valor} eh primo");
                }
                else
                {
                    Console.WriteLine($"{valor} nao eh primo");
                }                
            }
        }
    }
}
