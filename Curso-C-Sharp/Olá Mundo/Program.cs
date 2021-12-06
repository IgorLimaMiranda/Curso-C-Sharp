using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olá_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumero = 10;
            // Faz o boxing para o tipo referencia.
            Object objNumero = intNumero;

            // Faz o unboxing para o tipo valor
            int intValor = (int)objNumero;
        }
    }
}
