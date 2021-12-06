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