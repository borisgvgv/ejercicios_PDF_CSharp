/*
7.3.2) Crea una variante del ejercicio 7.2.2 (array de Trabajador y derivadas), en la
que se cree un único array "de trabajadores", que contenga un objeto de cada
clase, y exista un método "Saludar" que se redefina en todas las clases hijas,
usando "new" y probándolo desde "Main".
*/

using System;

public class Program
{
    public static void Main()
    {
        Trabajador[] trabajador = new Trabajador[3];
        trabajador[0] = new Trabajador();
        trabajador[1] = new Ingeniero();
        trabajador[2] = new Analista();

        trabajador[0].MostrarTrabajador();
        trabajador[1].MostrarTrabajador();
        trabajador[2].MostrarTrabajador();

    }
}

public class Trabajador
{
    public virtual void MostrarTrabajador()
    {
        System.Console.WriteLine("Hoy soy un trabajador");
    }
}

public class Ingeniero : Trabajador
{
    public override void MostrarTrabajador()
    {
        System.Console.WriteLine("Hoy soy un Ingeniero");
    }
}

public class Analista : Trabajador
{
    public override void MostrarTrabajador()
    {
        System.Console.WriteLine("Hoy soy un Analista");
    }
}


