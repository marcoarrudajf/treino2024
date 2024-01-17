using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class MenorValorVetor
    {
        public void menorValor()
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int menor = 0, pos = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
                menor = Math.Min(x[i], n);
                pos = x[i];
            }
            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Posicao: {pos}");
        }
    }
}
