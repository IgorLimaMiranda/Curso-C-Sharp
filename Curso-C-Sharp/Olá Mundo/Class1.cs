using System;

    class Class1
    {
        // atributo estático
        public static int total = 0;
        public int naoEstatico;
        public int idade;
        
        // o modificador default private é assumido neste caso
        string Nome;

        /*Atributos com o mesmo modificador de acesso e mesmo tipo podem ser
        agrupados.*/
        public int a, b, c;

        // método estático
        public static void inc()
        {
            total++;
        }

        /*[modificador de acesso] [tipo do método] <tipo do valor de retorno>
        <identificador do método>([lista de parâmetros])
        {
            // implementação
        }*/

        public void metodoTeste()
        {
            int numero = 0;
            numero++;
        }
     }

class teste
{
    // Método que recebe parâmetros por valor
    public void metValor(int parametro)
    {
        parametro++;
        Console.WriteLine(parametro);
    }

    // Método que recebe parâmetros por referência
    public void metRef(ref int parametro)
    {
        parametro++;
        Console.WriteLine(parametro);
    }

    // Parâmetros de saída: OUT
    public void metOut(ref int parametro, out int resultado)
    {
        parametro++;
        Console.WriteLine(parametro);
        resultado = parametro + 100;
    }

    // Passagem de número variável de parâmetros
    /*Quando o método receber mais de um parâmetro, o parâmetro array deve sero último da lista.*/
    public int Soma(params int[] args)
    {
        int total = 0;
        // implementação do método.
        foreach (int element in args)
        {
            total = total + element;
        }
        return (total);
    }

    // Valor de retorno de um método
    //public int soma(int a, int b)
    //{
    //    return a + b; //retornando uma expressão
    //}

    // OU

    public int soma(int a, int b)
    {
        int total = a + b;
        return total; //retornando uma variável
    }
}

//Constantes e atributos somente leitura.
class clConstantes
{
    public const int a = 100;
    public readonly int b;
    public static readonly int c;
    public clConstantes()
    {
        b = 200;
    }
    static clConstantes()
    {
        c = 300;
    }
}