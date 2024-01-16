using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class SelecaoVetor
    {
        public void validarVet()
        {
            double[] vet = new double[100];
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
