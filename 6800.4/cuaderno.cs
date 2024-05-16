using System;

class Cuaderno : Documento
{

    protected string titulo;
    public Cuaderno()
    {
        Console.WriteLine("Cuaderno");
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void Mostrar()
    {
        Console.WriteLine(titulo);
        Console.WriteLine();
    }

}