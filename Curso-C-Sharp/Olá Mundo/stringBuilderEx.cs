using System;
//namespace da classe StringBuilder
using System.Text;
public class stringBuilderEx
{
    static void Main()
    {
        // Criando um string Builder
        StringBuilder strB =
        new StringBuilder("Este ... um teste");
        // Convertendo o StringBuilder para string com
        //o método ToString()
        Console.WriteLine
        ("StringBuilder: {0}", strB.ToString());
        // Mostrando no console a capacidade do
        // StringBuilder com o método
        // strB.Capacity.ToString( )
        Console.WriteLine
        ("{0}", strB.Capacity.ToString());
        // Inserindo uma string qualquer na posiçao 8
        // do stringBuilder.
        strB.Insert(8, " é");
        Console.WriteLine("StringBuilder: {0}", strB.ToString());
        Console.ReadLine();

        /*------------------------------------------------------*/

        // Expressões e Operadores

        //Condicionais

        //Em C# existem dois tipos de condicionais: if e switch.

        /*O condicional if
        O if avalia uma expressão lógica booleana e qualquer outro tipo será acusado
        como erro pelo compilador. Se o resultado for verdadeiro, o bloco de código
        dentro do if será executado; caso contrário, o controle é passado para a próxima
        declaração após o if.Os projetistas de C# optaram por aceitar unicamente expressões
        boolenas no if para evitar escrever código com semântica obscura e
        propensa a resultados inesperados.*/

        //A declaração if tem três formas básicas:

        //1.
        /*if (expressão)
        {
                Declaração
        }*/

        //2.
        /*if (expressão)
        {
            Declaração
        }
        [else
        {
            Declaração
        }
        ]*/

        //3.
        /*if (expressão)
        {
            Declaração
        }
        [else if (expressão)
        {
        Declaração
        }
        ]*/

        //Vejamos alguns exemplos:
        int a = 0;
        int b = 1;
        if (a < b)
        {
            Console.WriteLine("B é maior");
        }
        else
        {
            Console.WriteLine("A é maior");
        }

        /*O exemplo anterior é sintaticamente correto, mas o que aconteceria se a = b ?
        O nosso código passaria a dar a resposta incorreta, porque ele não avalia a condição
        a = b, o que torna o nosso código inconsistente. Vamos reescrevê-lo de forma
        que a condição de igualdade seja avaliada:*/

        a = 0;
        b = 0;

        if (a < b)
        {
            Console.WriteLine("B é maior");
        }
        else if (a > b)
        {
            Console.WriteLine("A é maior");
        }
        else
        // e finalmente a condição de igualdade deveria ser
        // satisfeita
        {
            Console.WriteLine("A é igual a B");
        }

        stringBuilderEx obj = new stringBuilderEx();

        string str1 = "0";
        string str2 = "0";

        //Chamando o método:

        // if (obj.compString(str1,str2)) // uso ilegal!
        if (obj.compString(str1, str2) == 0) // uso correto!
        {
            Console.WriteLine("Strings diferentes");
        }
        else
        {
            Console.WriteLine("Strings iguais");
        }
        Console.ReadLine();

        //O condicional switch

        //A declaração switch avalia uma expressão cujo resultado pode ser dos tipos
        //sbyte, byte, short, ushort, int, uint, long, ulong, char, string ou enum, e este por
        //sua vez é comparado com cada uma das seções case que constituem o switch. Vejamos
        //a sua sintaxe:

        //        switch (expressão)
        //        {
        //            case constante1:
        //                declaração 1;
        //                break;
        //            case constante2:
        //                declaração 2;
        //                break; 
        //                //mais expressões case
        //                [default:
        //                declarações;
        //                break;
        //]
        //}

        //1.Em C#, é obrigatório que cada seção case tenha uma declaração break.
        //2.A seção default, que é avaliada caso nenhuma das seções case for verdadeira,
        //não é obrigatória.
        //3.Não pode existir mais de uma seção case com a mesma constante.Veja
        //o exemplo a seguir:
        //switch (compInt(10, 20))
        //{
        //    case 0:
        //        Console.WriteLine("A é igual a B");
        //        break;
        //    case 1:
        //        Console.WriteLine("A é menor do que B");
        //        break;
        //    case 1:
        //        Console.WriteLine("A é maior do que B");
        //        break;
        //}
        //O compilador acusará erro porque a constante “1” já foi definida na seção
        //case anterior.

        //Agora vejamos alguns exemplos do uso do switch:

        switch (compInt(10, 20))
        {
            case 0:
                Console.WriteLine("A é igual a B");
                break;
            case 1:
                Console.WriteLine("A é maior do que B");
                break;
            default:
                Console.WriteLine("A é menor do que B");
                break;
        }
        //Quando quisermos que várias seções case executem um mesmo bloco de declarações,
        //estas podem ser combinadas da seguinte forma:
        switch (compInt(10, 20))
        {
            case 0:
                Console.WriteLine("A é igual a B");
                break;
            // combinando seções case
            case 1: // A é maior do que B
            default: // -1 A é menor do que B
                Console.WriteLine("A é diferente de B");
                break;
            //A seção case cuja constante é “1”, quando satisfeita, executará as declarações
            //da seção default. Mais seções case poderiam ser acrescentadas e o resultado seria
            //sempre a execução da seção default.

            /*------------------------------------------------------*/
        }
    }
    //No exemplo a seguir tentaremos avaliar uma expressão inteira: 
    public int compString(string a, string b)
    {
        // implementação do método
        if (a == b)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
    public static int compInt(int iA, int iB)
    {
        if (iA == iB)
        {
            return 0;
        }
        else if (iA < iB)
        {
            return -1;
        }
        else return 1; // a > b
    }
}