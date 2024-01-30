using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    internal class Vetor3
    {
        public void metadeVetor()
        {
            decimal entrada = decimal.Parse(Console.ReadLine());
            int[] valor = new int[100];
            string numformat = entrada.ToString("F4");
            Console.WriteLine($"N[0] = {numformat}");
                decimal res = decimal.Parse(numformat);


            for (int i = 0; i < valor.Length; i++)
            {
                decimal soma = res / 2;
                Console.WriteLine($"N[{i}] = {(soma).ToString("F4")}");
                res = soma;
            }                                                                                                         }
    }
}
