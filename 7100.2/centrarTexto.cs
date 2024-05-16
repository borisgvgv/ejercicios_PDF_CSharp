using System;

public class CentrarTexto
{
    protected string texto;
    protected int totalWidth = Console.WindowWidth;
    protected int espacios;


    public void SetTexto(string texto)
    {
        this.texto = texto;
    }

    public void Mostrar()
    {
        espacios = (totalWidth - texto.Length) / 2;
        Console.WriteLine(texto.PadLeft(espacios + texto.Length));

    }

}