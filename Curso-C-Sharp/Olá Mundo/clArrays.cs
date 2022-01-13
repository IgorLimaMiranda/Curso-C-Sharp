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
        int[,] arrIntMult = new int[2, 2] { { 0, 0 }, { 0, 1 } };


        //Declarando um array de arrays:
        //private int[][,] ArrDeArr = new int[2][,] { new int[2, 3], new int[4, 5] };

        //Inicializando o array de arrays na declaração:
        private int[][,] ArrDeArr = new int[2][,] {new int[2,2] {{1,2},{3,4}}, new
        int[2,2]{{5,6},{7,8}}};

        /*-------------------------------------------------*/
    }
}
