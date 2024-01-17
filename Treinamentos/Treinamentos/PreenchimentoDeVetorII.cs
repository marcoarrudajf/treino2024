using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class PreenchimentoDeVetorII
    {
        //exercicio 1177 beecrowd
        public void sequenciaVetor()
        {
            int tam = int.Parse(Console.ReadLine());
            int[] n = new int[1000];
            int cont = 0;

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {cont}");
                cont++;
                if (cont >= tam)
                    cont = 0;
            }
        }
    }
}
