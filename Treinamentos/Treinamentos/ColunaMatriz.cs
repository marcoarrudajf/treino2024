using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class ColunaMatriz
    {
        public void colunaMatriz()
        {
            int col = int.Parse(Console.ReadLine());
            string test = Console.ReadLine();
            double soma = 0;
            double media = 0;
            double valor = 0;

            for (int i = 0; i <= 11; i++)
            {                     
                for (int j = 0; j <= col; j++)
                {
                    if (j == col)
                    {                            
                        valor = double.Parse(Console.ReadLine());
                        soma = soma + valor;
                        media = soma / 11;
                    }                      
                }
            }
            if ("S".Equals(test))
            {
                Console.WriteLine($"{soma.ToString("F1")}");
            }
            if ("M".Equals(test))
            {
                Console.WriteLine($"{media.ToString("F1")}");
            }
        }
    }
}
