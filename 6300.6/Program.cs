using System;

class Program
{
    static void Main(string[] args)
    {

        //Declaración de métodos
        Juego juego = new Juego();

        // Ejemplo de uso de la clase Nave
        try
        {
            Nave miNave = new Nave(512, 384); // Crear una nave en el centro de la pantalla
            Console.WriteLine("Posición de la nave: X = {0}, Y = {1}", miNave.X, miNave.Y);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }


        try
        {

            NaveII miNaveII = new NaveII(612, 1000); // Crear una nave en el centro de la pantalla

            //miNaveII.SetNaveII(612,484);
            //miNaveII.LanzarNaveII();
            Console.WriteLine("Posición de la naveII: X = {0}, Y = {1}", miNaveII.J, miNaveII.K);


        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //Lanzar juego
        juego.Espacio();


    }
}
