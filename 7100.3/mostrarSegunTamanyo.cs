using System;

public class MostrarSegunTamanyo
{
    private Program.tipoFicha[] fichas;
    private int numeroFichas;
    private long tamanyoBuscar;

    public MostrarSegunTamanyo(Program.tipoFicha[] fichas)
    {
        this.fichas = fichas;
    }
    public void SetTamanyoBuscar(long tamanyoBuscar)
    {
        this.tamanyoBuscar = tamanyoBuscar;
    }

    public void SetNumeroFichas(int numeroFichas)
    {
        this.numeroFichas = numeroFichas;
    }

    public void Mostrar()
    {

        for (int i = 0; i < numeroFichas; i++)
            if (fichas[i].tamanyo >= tamanyoBuscar)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                fichas[i].nombreFich, fichas[i].tamanyo);
    }

}
