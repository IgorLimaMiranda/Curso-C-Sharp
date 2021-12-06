    /*[modificador de acesso] class <identificador> : [classe base]
    {
        // declaração de atributos e métodos
    }*/

    public class funcionario
    {
        private string nome;
        private double salarioBruto;
        private string funcID;

        // Em C#, a implementação de métodos é Inline.

        public double CalcularSalarioLiquido(string ID)
        {
            return salarioBruto * 0.9;
        }
    }
