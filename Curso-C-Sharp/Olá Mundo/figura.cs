using System;

// Tipos aninhados
class figura
{
    public struct Circulo
    {
        private int x, y;
        private float diametro;
        public Circulo(int a, int b, float Diametro)
        {
            x = a;
            y = b;
            diametro = Diametro;
        }
    }
    public struct Elipse
    {
    }
    public void teste()
    {
        Circulo cl = new Circulo(0, 0, 10);
        Console.WriteLine("Usando tipos aninhados");
    }
}