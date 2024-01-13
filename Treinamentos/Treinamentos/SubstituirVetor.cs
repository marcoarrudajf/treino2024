using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class SubstituirVetor
    {
        public void numeroPositivo()
        {
            int[] num = new int[10];
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] <= 0)
                {
                    num[i] = 1;
                }
                Console.WriteLine($"X[{i}] = {num[i]}");
            }

        }

    }
}
