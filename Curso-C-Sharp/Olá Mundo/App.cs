using System;
public class App
{
    // Atributos de uma classe ou campos da classe
    // [Modificador de acesso] [tipo atributo] <tipo da variável> <identificador>
    public int varInt;
    static void Main()
    {
        // Variável locais
        int varLocal;
        
        Console.WriteLine(Class1.total++);
        Class1.inc();

        Class1 cl1 = new Class1();
        Console.WriteLine(Class1.total++);

        Class1 cl2 = new Class1();
        Console.WriteLine(Class1.total);

        Console.ReadLine();
    }
}