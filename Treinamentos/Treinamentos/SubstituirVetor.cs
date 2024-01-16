using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class SubstituirVetor
    {
        //desafio 1172 - Número Primo Beecrowd
        public void numeroPositivo()
        {
            //declarado vetor de 10
            int[] num = new int[10];

            //percorrer vetor
            for (int i = 0; i < num.Length; i++)
            {
                //ler valor a ser comparado caso seja positivo retorna ele mesmo, caso seja negativo retorna o valor 1
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] <= 0)
                {
                    num[i] = 1;
                }
                //mostrar retultado conforme pedido no enunciado.
                Console.WriteLine($"X[{i}] = {num[i]}");
            }

        }

    }
}
