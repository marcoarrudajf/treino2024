using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class TrocaVetor
    {
        //exercicio 1175 beecrowd
        public void trocarVet()
        {
            double[] vet = new double[20];

            //percorrer vetor para entrada começando de forma invertida
            for (int i = vet.Length - 1; i >= 0; i--)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }
            //percorrer vetor para saida
            for (int i = 0; i < vet.Length; i++)
            {                 
                Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}
