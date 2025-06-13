/*
(7.6.1) Desarrolla una clase "Matriz", que represente a una matriz de 3x3, con
métodos para indicar el valor que hay en una posición, leer el valor de una
posición, escribir la matriz en pantalla y sumar dos matrices. (Nota: en C# puedes
sobrecargar el operador "+", pero no el operador "[]", de modo que tendrás que
crear métodos "get" y "set" para leer los valores de posiciones de la matriz y para
cambiar su valor).
*/

using System;
public class Program
{
    public static void Main()
    {

        Matriz matriz_1 = new Matriz(3);
        Matriz matriz_2 = new Matriz(3);

        matriz_1.Set(0, 0, 1);
        matriz_1.Set(0, 1, 2);
        matriz_1.Set(0, 2, 3);

        matriz_1.Set(1, 0, 4);
        matriz_1.Set(1, 1, 5);
        matriz_1.Set(1, 2, 6);

        matriz_1.Set(2, 0, 7);
        matriz_1.Set(2, 1, 8);
        matriz_1.Set(2, 2, 9);

        matriz_2.Set(0, 0, 10);
        matriz_2.Set(0, 1, 11);
        matriz_2.Set(0, 2, 12);

        matriz_2.Set(1, 0, 13);
        matriz_2.Set(1, 1, 14);
        matriz_2.Set(1, 2, 15);

        matriz_2.Set(2, 0, 16);
        matriz_2.Set(2, 1, 17);
        matriz_2.Set(2, 2, 18);

        Matriz resultado = matriz_1 + matriz_2;
        System.Console.WriteLine("Resultado de la suma entre matriz_1 y matriz_2");
        resultado.Mostrar();

    }
}

public class Matriz
{
    protected int[,] datos;
    protected int tamanyo;

    //Constructor
    public Matriz(int tamanyo)
    {
        this.tamanyo = tamanyo;
        datos = new int[tamanyo, tamanyo];
    }

    //Método para obtener un valor
    public int Get(int x, int y) => datos[x, y];

    //Metodo para pasar un valor
    public void Set(int x, int y, int valor) => datos[x, y] = valor;

    //Sobrecarga del operador
    public static Matriz operator +(Matriz mat1, Matriz mat2)
    {
        Matriz resultado = new Matriz(mat1.tamanyo);

        for (int i = 0; i < mat1.tamanyo; i++)
        {
            for (int j = 0; j < mat1.tamanyo; j++)
            {
                resultado.Set(i, j, mat1.Get(i, j) + mat2.Get(i, j));
            }
            
        }
        return resultado;
    }

    //Mostrar la matriz por consola
    public void Mostrar()
    {
        for (int i = 0; i < tamanyo; i++)
        {
            for (int j = 0; j < tamanyo; j++)
            {
                System.Console.WriteLine(Get(i, j) + "\t");
                System.Console.WriteLine();//salto de linea
            }
        }
    }

}


