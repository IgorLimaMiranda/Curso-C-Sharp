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
    }
}