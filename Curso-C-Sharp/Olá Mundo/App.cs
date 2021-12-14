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

        teste class1 = new teste();

        int argValor = 10;

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
        Console.WriteLine("Parâmetro de saída OUT:");
        Console.WriteLine(res);
        Console.ReadLine();

        /*-------------------------------------------------*/

        int total;

        // Passagem de número variável de parâmetros
        total = class1.Soma(1, 2, 3, 4);
        Console.WriteLine(total);
        total = class1.Soma(10, 20);
        Console.WriteLine(total);
        Console.ReadLine();

        /*-------------------------------------------------*/

        // Valor de retorno de um método
        // o valor de retorno é armazenado na variável total.
        total = class1.soma(5, 10);

        Console.WriteLine(total);

        Console.ReadLine();
        
        // Constantes e atributos somente leitura
        clConstantes cl = new clConstantes();
        Console.WriteLine("Constante: {0}", clConstantes.a);
        Console.WriteLine("Atributo Readonly: {0}", cl.b);
        Console.WriteLine("Atributo Readonly Estático: {0}", clConstantes.c);

        Console.ReadLine();
    }
}

class CsharpApp
{
    static void Main()
    {
        // Construtores de instâncias

        // construtor default
        Circulo cl1 = new Circulo();
        // construtores customizados
        Circulo cl2 = new Circulo(1, 2);
        Console.ReadLine();
    }
}