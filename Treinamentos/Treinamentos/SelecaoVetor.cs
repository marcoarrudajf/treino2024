using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class SelecaoVetor
    {
        //exercicio   1174 beecrowd
        public void validarVet()
        {
            double[] vet = new double[100];
            //percorrer um vetor de 100 posiçoes retornando apenas os valores <= 10.
            for (int i = 0; i < 100; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {vet[i].ToString("F1")}");
                }
            }
        }
    }
}
