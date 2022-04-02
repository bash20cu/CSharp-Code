using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPildorasInformaticas
{
    internal class Metodos
    {
        // Metodo que no devuelve nada.
        public static void sumaNumeros()
        {
            int numero1 = 7, numero2 = 9;
            int resultado = numero1 + numero2;
            Console.WriteLine(resultado);
        }
        //Metodo que devuelve un resultado, pero no tiene parametros
        public static int sumaNumerosReslt()
        {
            int numero1 = 7, numero2 = 9;
            int resultado = numero1 + numero2;
            return resultado;
        } 

        //Metodo que recibe 2 parametros y devuelve un resultado
        public static int sumaNumerosConParam(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        // Metodo simple 
        public static int divideNumeros(int numero1, int numero2) => numero1 / numero2;


        //Sobrecarga de metodos        
        public static int sumaSobrecarga(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int sumaSobrecarga(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static int sumaSobrecarga(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
        
    }
}
