using System;

public class MostrarDatos
{

    private Program.tipoFicha[] fichas;
    private int numeroFichas;

    public MostrarDatos(Program.tipoFicha[] fichas)
    {
        this.fichas = fichas;
    }

    // Hacemos que AddDatos vea el Array fichas desde Program
    public void SetNumeroFichas(int numeroFichas)
    {
        this.numeroFichas = numeroFichas;
    }

    public void Mostrar()
    {
        for (int i = 0; i < numeroFichas; i++)
            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
            fichas[i].nombreFich, fichas[i].tamanyo);
    }



}