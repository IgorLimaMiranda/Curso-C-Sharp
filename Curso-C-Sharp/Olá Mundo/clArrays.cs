using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olá_Mundo
{
    /*Arrays
    Em C#, arrays são objetos cuja classe base é System.Array. Os arrays podem ser
    unidimensionais, multidimensionais ou ainda arrays de arrays, cujos elementos
    são outros arrays.*/
    class clArrays
    {
        //Declaração de um array unidimensional:
        //int[] arrIntUnid = new int[2];

        //Inicializado o array unidimensional:
        //int[] arrIntUnid = new int[2] { 0, 1 }; //ou
        //int[] arrIntUnid = new int[] { 0, 1 }; //ou
        int[] arrIntUnid = { 0, 1 };

        //Declarando um exemplo multidimensional de 2×2 dimensões:
        //int[,] arrIntMult = new int[2, 2];

        //Inicializando o array multidimensional:
        int[,] arrIntMult = new int[2, 2]
        {
            { 0, 0 },
            { 0, 1 }
        };


        //Declarando um array de arrays:
        /*private int[][,] ArrDeArr = new int[2][,] 
        { 
            new int[2, 3], 
            new int[4, 5] 
        };*/

        //Inicializando o array de arrays na declaração:
        private int[][,] ArrDeArr = new int[2][,]
        {
            new int[2,2]
            {
                {1,2},{3,4}
            },
            new int[2,2]
            {
                {5,6},{7,8}
            }
        };
        /*Basicamente, o que estamos fazendo no último exemplo é declarar um array
        que, por sua vez, contém dois arrays bidimensionais.*/

        /*-------------------------------------------------*/

        //Veja um exemplo completo:

        private int[] arrInt = new int[2] { 1, 2 };
        private int[,] multInt = new int[2, 2]
        { { 1, 2 },
          { 3, 4 }
        };
        private int[][,] ArrDeArrs = new int[2][,]
        {
            new int[2,2]
        {
            {1,2},
            {3,4}
        },
        new int[2,2]
        {
            {5,6},
            {7,8}
        }
        };

        public void ImprimirArray()
        {
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine("Elemento {0}: {1}", i, arrInt[i]);
            }
        }

        //Preechendo um array bidimensional:
        public void preencherArrayBi()
        {
            for (int i = 0; i < multInt.GetLength(0); i++)
                for (int j = 0; j < multInt.GetLength(1); j++)
                {
                    multInt[i, j] = i * j;
                }
        }
        /*No exemplo acima, usamos o método GetLength() da classe System.Array
        para saber o número de elementos de cada dimensão.Esse método recebe como
        parâmetro um número inteiro que corresponde à dimensão acerca da qual queremos
        conhecer o número de elementos.*/

        //Preenchendo um array de arrays:
        public void preencherJaggedArray()
        {
            for (int m = 0; m < ArrDeArr.Length; m++)
                for (int i = 0; i < ArrDeArr[m].GetLength(0); i++)
                    for (int j = 0; j < ArrDeArr[m].GetLength(1); j++)
                    {
                        ArrDeArr[m][i, j] = i + j;
                    }
        }
        //Mostrando um array bidimensional no console:
        public void ImprimirArrayBi()
        {
            Console.WriteLine("Array Bi-dimensional");
            for (int i = 0; i < multInt.GetLength(0); i++)
            {
                for (int j = 0; j < multInt.GetLength(1); j++)
                {
                    Console.Write("{0}\t", multInt[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
        //Mostrando um array de arrays no console:
        public void ImprimirJaggedArray()
        {
            Console.WriteLine("Imprimindo Array de Arrays");
            for (int m = 0; m < ArrDeArrs.Length; m++)
            {
                Console.WriteLine("ArrDeArr[{0}]", m);
                for (int i = 0; i < ArrDeArrs[m].GetLength(0); i++)
                {
                    for (int j = 0; j < ArrDeArrs[m].GetLength(1); j++)
                    {
                        Console.Write("{0}\t", ArrDeArrs[m][i, j]);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}