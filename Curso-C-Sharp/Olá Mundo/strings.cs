using System;
public class strings
{
    static void Main()
    {
        string str = "Strings em C#";
        string concatStr;
        string novoStr;
        Console.WriteLine("Strings de exemplo: {0}", str);
        // concatenando strings
        concatStr = str + " e .NET";
        Console.WriteLine
        ("Strings de exemplo: {0}", concatStr);
        // Mostrando o tamanho do string com o método //Length
        Console.WriteLine
        ("Tamanho do string concatStr: {0}",
        concatStr.Length.ToString());
        // Extraindo um sub-string como o método
        //Substring
        Console.WriteLine
        ("Sub-string de concatStr: {0}",
        concatStr.Substring(0, 7));
        // Comparando strings com o operador "=="
        //sobre-carregado
        if (concatStr == str)
            Console.WriteLine("Strings iguais");
        else
            Console.WriteLine("Strings diferentes");
        Console.ReadLine();
    }
}