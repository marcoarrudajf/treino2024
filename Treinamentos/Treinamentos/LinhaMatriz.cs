using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    internal class LinhaMatriz
    {
        public void linhaDaMatriz()
        {
            int l = int.Parse(Console.ReadLine());
            string test = Console.ReadLine();
            double soma = 0;
            double media = 0;
            for (int i = 0; i <= 11; i++)
            {                   
                if (i == l)
                {
                    for (int j = 0; j < l; j++)
                    {                           
                        double valor = double.Parse(Console.ReadLine());
                        soma = soma + valor;
                        media = soma / (double)l;
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
