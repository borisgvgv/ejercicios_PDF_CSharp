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

        // matriz_1
        matriz_1.Set(0, 0, 1);
        matriz_1.Set(0, 1, 2);
        matriz_1.Set(0, 2, 3);

        matriz_1.Set(1, 0, 4);
        matriz_1.Set(1, 1, 5);
        matriz_1.Set(1, 2, 6);

        matriz_1.Set(2, 0, 7);
        matriz_1.Set(2, 1, 8);
        matriz_1.Set(2, 2, 9);

        // matriz_2
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
    // Aquí creo una posición en "datos = new int[tamanyo, tamanyo];" donde poder poner un dato 
    public Matriz(int tamanyo)
    {
        this.tamanyo = tamanyo;
        datos = new int[tamanyo, tamanyo];
    }

    //Método para obtener los valores la posición donde estarán los valores de los datos dentro del array
    public int Get(int x, int y) => datos[x, y];

    //Metodo para pasar un valor y añadirlo a la posición [x,y] que indiquemos dentro del array
    public void Set(int x, int y, int valor) => datos[x, y] = valor;

    //Sobrecarga del operador
    public static Matriz operator +(Matriz mat1, Matriz mat2)
    {
        Matriz resultado = new Matriz(mat1.tamanyo);

        for (int x = 0; x < mat1.tamanyo; x++)
        {
            for (int y = 0; y < mat1.tamanyo; y++)
            {
                resultado.Set(x, y, mat1.Get(x, y) + mat2.Get(x, y));
            }

        }
        return resultado;
    }

    //Mostrar la matriz por consola
    public void Mostrar()
    {
        for (int x = 0; x < tamanyo; x++)
        {
            for (int y = 0; y < tamanyo; y++)
            {
                System.Console.WriteLine(Get(x, y) + "\t");
                System.Console.WriteLine();//salto de linea
            }
        }
    }

}


