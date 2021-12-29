using System;

// Tipo Enumerado
enum dias_da_semana : uint
{
    domingo = 100, //0
    segunda = 50,  //1
    terca = 34,    //2
    quarta = 3,    //3
    quinta,        //4
    sexta = 60,    //5
    sabado = 70,    //6
    /*Um determinado elemento de um tipo enumerado pode compartilhar o mesmo
    valor inteiro com outro elemento da lista. Vejamos:*/
    dia_de_festa = sabado,
    dia_de_descanso = domingo,
    /*Ambiguidade entre 'dias_da_semana.dia_de_descanso' e 'dias_da_semana.dia_de_descanso'
    domingo = dia_de_descanso,
    dia_de_descanso*/
    /*O compilador acusará um erro porque o valor do elemento segunda está fora
    do intervalo do tipo uint.
    hontem = -1*/
}

public class App
{
    // Atributos de uma classe ou campos da classe
    // [Modificador de acesso] [tipo atributo] <tipo da variável> <identificador>
    public int varInt;
    static public void Main()
    {
        // Tipo Enumerado
        /*Os membros de um tipo enumerado não possuem modificadores de acesso, e
        estes são acessíveis desde que o tipo enum que os contém seja acessível.*/
        //(int) --> Usou Cast para converter explicitamente o tipo 'dias_da_semana' em 'int'.
        int quinta = (int)dias_da_semana.quinta;
        int sexta = (int)dias_da_semana.sexta;
        Console.WriteLine("quinta = {0}", quinta);
        Console.WriteLine("sexta = {0}", sexta);
        Console.ReadLine();

        /*-------------------------------------------------*/

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

        Console.WriteLine("VALOR DE PI: {0}", classeDeConstantes.pi);

        Console.WriteLine("TEMPERATURA DE FEVOR DA ÁGUA: {0}", classeDeConstantes.iTempDeFervorDaAgua);

        Console.ReadLine();

        /*Para criarmos uma variável de um tipo struct:
        <tipo_struct> identificador = new <tipo_struct>[parâmetros do construtor]*/
        str_Circulo cl3 = new str_Circulo(0, 1, 10);
        
        Console.ReadLine();

        figura fig = new figura();
        fig.teste();

        Console.ReadLine();
    }
}