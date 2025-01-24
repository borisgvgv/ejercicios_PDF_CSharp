using System;
public class Puerta
{
    public static void Main()
    {
        classPuerta p = new classPuerta();
        classPuerta p2 = new classPuerta(90, 220);
        //-------

        Console.WriteLine("Valores iniciales...");
        p.SetAbiertaOSerrada(false);
        p.MostrarPuerta();
        Console.WriteLine();

        Console.WriteLine("Vamos a abrir...");
        p.SetAbiertaOSerrada(true);
        p.MostrarPuerta();
        Console.WriteLine();

        Console.WriteLine("Para la segunda puerta...");
        p.SetAbiertaOSerrada(false);
        p2.MostrarPuerta();
    }
}


/*

Un destructor se creará con el mismo nombre que la clase y que el constructor,
pero precedido por el símbolo "~", y no tiene tipo de retorno, ni parámetros, ni
especificador de acceso ("public" ni ningún otro), como ocurre en este ejemplo:

~Puerta()
    {
        // Liberar memoria
        // Cerrar ficheros
    }
*/
