using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamentos
{
    class NumeroPrimo
    {
        //desafio 1165 - Número Primo Beecrowd
        public void numPrimos()
        {
            //le a quantidade de vezes que será verificado o numero primo
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                //contar o resultado
                int res = 0;
                //ler o numero a ser verificado se é primo ou não
                int valor = int.Parse(Console.ReadLine());
                //percorre o valor realizando o calculo para saber o resto da divisão é igual a zero, caso o resultado seja menor que 3 será primo.
                for (int j = 1; j <= valor; j++)
                {
                    if (valor % j == 0)
                    {
                        res++;
                    }
                }
                //verifica se o número de divisores é menor ou igual a 2 (é primo) e imprime o resultado
                if (res <= 2)
                {
                    Console.WriteLine($"{valor} eh primo");
                }
                else
                {
                    Console.WriteLine($"{valor} nao eh primo");
                }
            }
            /* Um número primo é aquele que apenas é divisível por 1 e por si mesmo. 
               Obrigado por acessar meu código.
             */
        }
    }
}
