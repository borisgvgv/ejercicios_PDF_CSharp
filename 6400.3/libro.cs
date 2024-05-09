using System;

public class Libro : Documento
{

    protected int pag;

    public Libro(){
        pag = 0;
    }

    public int GetPag(){
        return pag;
    }
    public void SetPag(int pag){
        this.pag = pag;
    }

    public new void Mostrar()
    {
        Console.WriteLine("Titulo: {0}", titulo);
        Console.WriteLine("Lanzamiento: {0}", lanzamiento);
        Console.WriteLine("Páginas {0}", pag);
        Console.WriteLine();

    }

}