/*
(7.5.1) Crea una versión ampliada del ejercicio 7.4.2, en la que el constructor sin
parámetros de la clase "Trabajador" se apoye en otro constructor que reciba como
parámetro el nombre de esa persona. La versión sin parámetros asignará el valor
"Nombre no detallado" al nombre de esa persona.
*/

using System;

public class Program
{
    public static void Main()
    {
        Trabajador t1 = new Trabajador();
        Trabajador t2 = new Trabajador("Boris");

        t1.Mostrar();
        t2.Mostrar();

    }
}

public class Trabajador
{
    protected string nombre;
    public Trabajador() : this("Nombre no detallado")
    {
    }
    public Trabajador(string nombre)
    {
        this.nombre = nombre;
    }

    public void Mostrar()
    {
            Console.WriteLine("El trabajador es: {0}", nombre);
    }

}