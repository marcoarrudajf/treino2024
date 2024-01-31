using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class MenorValor
    {
        public void menorValor()
        {
            int qtde = int.Parse(Console.ReadLine());
            int[] valor = new int[qtde];             
            int pos = 0;
            String[] str = Console.ReadLine().Split();

            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = int.Parse(str[i]);
            }
            int menorValor = valor[0];

            for (int j = 0; j < valor.Length; j++)
            {
                if (valor[j] < menorValor) 
                {
                    menorValor = valor[j];
                    pos = j;
                }
            }

            Console.WriteLine($"Menor valor: {menorValor}\nPosicao: {pos}");
        }

    }
}
