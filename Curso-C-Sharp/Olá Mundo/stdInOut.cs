using System;

public class stdInOut
{
    static void Main()
    {
        char c;
        string str;
        // Escreve no console sem retorno de carro
        Console.Write("Digite seu nome: ");
        // Lê uma string do console. <Enter> para concluir
        str = Console.ReadLine();
        // Escreve no console sem retorno de carro
        Console.Write("Digite uma vogal e tecle <Enter>:");
        // Lê do console um caractere simples.
        c = (char)Console.Read();
        // Escreve uma linha em branco
        Console.WriteLine();
        // Escreve uma string no console
        Console.WriteLine("Seu nome é: {0}", str);
        // Escreve 1 caractere com ToString( ) para converter
        Console.WriteLine("Sua vogal: {0}", c.ToString());
        Console.ReadLine();

        /* 
        Formatando a saída padrão
        // \t = TAB
        // \n = quebra de linha e retorno de carro (CR LF)
        // Console.WriteLine("var1: {0} \t var2: {1}\t var3: {2}\n", var1, var2, var3); 
        */

        Console.ReadKey();
    }
}