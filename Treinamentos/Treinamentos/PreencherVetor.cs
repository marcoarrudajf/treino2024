using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class PreencherVetor
    {
        //exercício beecrowd 1173
        public void preencherVet()
        {
            //entrada de um valor inteiro qualquer 
            int v = int.Parse(Console.ReadLine());
            //declaração de array de 10
            int[] num = new int[10];

            num[0] = v;
            Console.WriteLine($"N[0] = {num[0]}");

            //percorre o vetor a partir de 1
            for (int i = 1; i < num.Length; i++)
            {
                num[i] = num[i - 1] * 2;
                Console.WriteLine($"N[{i}] = {num[i]}");
            }
        }
    }
}
