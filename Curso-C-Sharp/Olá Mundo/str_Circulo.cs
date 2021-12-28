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
/*Quando usar estruturas:
Se as estruturas são tão semelhantes a classes, então quando devemos usar estruturas
e quando devemos usar classes? Vejamos:
 Quando se está lidando com estruturas de dados pequenas.
 Quando não precisamos de suporte para o mecanismo de herança.
 O uso de classes é mais custoso em termos de desempenho e uso da memória,
portanto, quando as duas características acima forem verdadeiras, o
recomendado é usar uma estrutura e não uma classe.*/
