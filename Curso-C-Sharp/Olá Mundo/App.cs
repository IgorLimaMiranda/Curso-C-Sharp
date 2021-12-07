using System;
public class App
{
    // Atributos de uma classe ou campos da classe
    // [Modificador de acesso] [tipo atributo] <tipo da variável> <identificador>
    public int varInt;
    static public void Main()
    {
        // Variável locais
        int varLocal;
        
        Console.WriteLine(Class1.total++);
        Class1.inc();

        Class1 cl1 = new Class1();
        Console.WriteLine(Class1.total++);

        Class1 cl2 = new Class1();
        Console.WriteLine(Class1.total);

        /*-------------------------------------------------*/

        int argValor = 10;

        teste class1 = new teste();

        // Passagem de parâmetro por valor
        class1.metValor(argValor);
        Console.WriteLine("Passagem de parâmetro por valor:");
        Console.WriteLine(argValor);
        Console.ReadLine();

        /*-------------------------------------------------*/

        int parRef = 10;

        // Passagem de parâmetro por referência
        class1.metRef(ref parRef);
        Console.WriteLine("Passagem de parâmetro por referência:");
        Console.WriteLine(parRef);
        Console.ReadLine();

        /*-------------------------------------------------*/

        // Parâmetro de saída: OUT
        int argValor1 = 10, res;
        
        class1.metOut(ref argValor1, out res);
        Console.WriteLine("Passagem de parâmetro por referência:");
        Console.WriteLine(argValor1);
        Console.WriteLine("Parâmetro de saída: OUT:");
        Console.WriteLine(res);
        Console.ReadLine();

        Console.ReadLine();

        /*-------------------------------------------------*/
    }
}