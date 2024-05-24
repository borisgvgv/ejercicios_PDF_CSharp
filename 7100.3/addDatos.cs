using System;

public class AddDatos
{

    private Program.tipoFicha[] fichas;
    private int numeroFichas;

    // Hacemos que AddDatos vea el Array fichas desde Program

    public AddDatos(Program.tipoFicha[] fichas)
    {
        this.fichas = fichas;

    }

    // Method to Set the updated number of fichas
    public void SetNumeroFichas(int numeroFichas)
    {
        this.numeroFichas = numeroFichas;
    }


    public void Mostrar()
    {
        if (numeroFichas < 1000)
        { // Si queda hueco
            Console.WriteLine("Introduce el nombre del fichero: ");
            fichas[numeroFichas].nombreFich = Console.ReadLine();
            Console.WriteLine("Introduce el tamaño en KB: ");
            fichas[numeroFichas].tamanyo = Convert.ToInt32(
            Console.ReadLine());
            // Y ya tenemos una ficha más
            //numeroFichas++;
        }
        else // Si no hay hueco para más fichas, avisamos
            Console.WriteLine("Máximo de fichas alcanzado (1000)!");
    }

}
