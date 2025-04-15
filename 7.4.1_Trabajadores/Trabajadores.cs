using System;

public class Trabajadores
{
    public static void Main()
    {
        Console.Clear();
        Analista analista = new Analista();
        Informatico informatico = new Informatico();
        Informatico2 informatico2 = new Informatico2();
        
        analista.Mostrar();
        System.Console.WriteLine();
        informatico.Mostrar();
        System.Console.WriteLine();
        informatico2.Mostrar();
        System.Console.WriteLine();
    }
}

public class Trabajador
{
    public void Mostrar()
    {
        System.Console.Write("Hola soy un trabajador ");
    }
}

/*------------------------------------------------------*/

public class Analista : Trabajador
{
    public void Mostrar()
    {
        base.Mostrar();
        System.Console.Write("Analista ");

    }
}

/*------------------------------------------------------*/

public class Informatico : Trabajador
{
    public void Mostrar()
    {
        base.Mostrar();
        System.Console.Write("Informático ");
                

    }
}

/*------------------------------------------------------*/

public class Informatico2 : Analista
{
    public void Mostrar()
    {
        base.Mostrar();
        System.Console.Write("Informático ");

    }
}
