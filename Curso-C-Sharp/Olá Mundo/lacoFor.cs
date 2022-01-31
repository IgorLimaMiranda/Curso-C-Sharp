//  Laços
//  A linguagem C# dá suporte a quatro tipos diferentes de laços:
//  for
//  foreach/in
//  while
//  do/while

// O laço for
// O laço for segue o mesmo estilo das linguagens C / C++, e a sua sintaxe tem as seguintes
// características:
// Uma variável de inicialização pode ser declarada dentro do for.
// Uma condição avalia uma expressão para abandonar o for ou executá-lo
// de novo.
// Uma expressão incrementa o valor da variável de inicialização.

// Exemplo:

using System;
public class lacoFor
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iteração número {0}", i);
        }
        Console.ReadLine();

        //Para abandonar o laço antes que a condição for seja falsa, usa-se a palavra reservada
        //break.

        //Exemplo:
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Iteração número {0}", i);
            if (i == 3)
                break;
        }
        Console.ReadLine();
        //A palavra reservada continue permite que o fluxo de execução da iteração
        //corrente seja abandonado, mas não o laço, e a iteração seguinte dê início no topo
        //do laço, uma vez que a condição do for seja satisfeita.

        //Exemplo:
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Iteração número {0}", i);
            if (i == 3)
                break;
        }
        Console.ReadLine();
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Iteração número {0}", i);
            if (i == 3)
                continue;

            // a declaração a seguir não será executada quando i==3
            Console.WriteLine("Iteração número {0}", i + 2);
        }
        Console.ReadLine();
    
    }
}