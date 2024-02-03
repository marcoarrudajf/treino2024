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
            double[,] matriz = new double[12, 12];

            int coluna = int.Parse(Console.ReadLine());
            char operacao = char.Parse(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double soma = 0.0;

            for (int i = 0; i < 12; i++)
            {
                soma += matriz[i, coluna];
            }

            if (operacao == 'M')
            {
                soma /= 12;
            }

            Console.WriteLine($"{soma:0.0}");
        }
    }
}
