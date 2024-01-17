using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class Fibonacci
    {
        public void fibo()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                long resultado = fibon(N);
                Console.WriteLine($"Fib({N}) = {resultado}");
            }
        }
        static long fibon(int n)
        {
            long a = 0;
            long b = 1;

            if (n <= 1)
            {
                return n;
            }
            else
            {
                long temp;
                for (int i = 2; i <= n; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
        }
    }
}
