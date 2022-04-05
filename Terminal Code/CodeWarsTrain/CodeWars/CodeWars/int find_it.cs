using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class int_find_it
    {
        public static int find_it(int [] integers)
        {
            int par = 0 , impar = 0, numeroPar=0,numeroImpar=0;

            for (int i = 0 ; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
                int num1 = integers[i];
                
                if (num1 % 2 == 0)
                {
                    par += 1;
                    numeroPar = num1; 
                }
                if (num1 % 2 != 0)
                {
                    impar += 1;
                    numeroImpar = num1;
                }
            }
            Console.WriteLine($"total de numeros pares:{par} ");
            Console.WriteLine($"total de numeros impares:{impar} ");
            Console.WriteLine($"numero par hallado {numeroPar}");
            Console.WriteLine($"numero impar hallado {numeroImpar}");
            if(par > impar)
            {
                return numeroImpar;
            }
            else
            {
                return numeroPar;
            }            
        } 
    }
}
