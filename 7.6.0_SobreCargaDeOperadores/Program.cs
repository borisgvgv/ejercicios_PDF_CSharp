using System;

public class Matriz
{
    private int[,] datos;
    public int tamanyo;

    // Constructor
    public Matriz(int tamanyo)
    {
        this.tamanyo = tamanyo;
        datos = new int[tamanyo, tamanyo];
    }

    // Método para obtener un valor
    public int Get(int x, int y) => datos[x, y];

    // Método para poner un valor
    public void Set(int x, int y, int valor) => datos[x, y] = valor;

    // Sobrecarga del operador +
    public static Matriz operator +(Matriz mat1, Matriz mat2)
    {
        Matriz resultado = new Matriz(mat1.tamanyo);

        for (int x = 0; x < mat1.tamanyo; x++)
            for (int y = 0; y < mat1.tamanyo; y++)
                resultado.Set(x, y, mat1.Get(x, y) + mat2.Get(x, y));

        return resultado;
    }

    // Mostrar la matriz por consola
    public void Mostrar()
    {
        for (int x = 0; x < tamanyo; x++)
        {
            for (int y = 0; y < tamanyo; y++)
                Console.Write(Get(x, y) + "\t");
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Crear dos matrices 2x2
        Matriz m1 = new Matriz(2);
        Matriz m2 = new Matriz(2);

        // Rellenar m1
      
        m1.Set(0, 0, 1);
        m1.Set(0, 1, 2);
        m1.Set(1, 0, 3);
        m1.Set(1, 1, 4);

        // Rellenar m2
        m2.Set(0, 0, 5);
        m2.Set(0, 1, 6);
        m2.Set(1, 0, 7);
        m2.Set(1, 1, 8);
    

        // Sumar las dos matrices
        Matriz resultado = m1 + m2;

        // Mostrar el resultado
        Console.WriteLine("Matriz resultado:");
        resultado.Mostrar();
    }
}
