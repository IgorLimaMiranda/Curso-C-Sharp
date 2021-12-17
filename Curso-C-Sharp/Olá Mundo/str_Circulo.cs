using System;

/*A declaração da estrutura:
[modificador de acesso] struct <nome da estrutura> : [interface]
{
    //membros da estrutura
}*/
struct str_Circulo
{
    private int x, y;
    private float diametro;
    public str_Circulo(int a, int b, float Diametro)
    {
        x = a;
        y = b;
        diametro = Diametro;
        Console.WriteLine("X: {0}",x);
        Console.WriteLine("Y: {0}",y);
        Console.WriteLine("DIAMETRO: {0}",diametro);
    }
}
