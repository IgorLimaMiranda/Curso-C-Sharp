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
}