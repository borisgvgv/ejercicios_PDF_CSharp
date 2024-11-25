using System;

class Program
{
    static void Main()
    {

        int[] datos = { 5, 3, 14, 20, 8, 9, 1 };
        int datoTemporal;
        int n = 7; // Numero de datos

        //-------------MÉTODO BURBUJA----------
        // (Intercambiar cada pareja consecutiva que no esté ordenada)
        // Para i=1 hasta n-1
        // Para j=i+1 hasta n
        // Si A[i] > A[j]
        // Intercambiar (A[i], A[j])

        System.Console.WriteLine();
        System.Console.WriteLine("Ordenando datos ordenados con metodo burbuja ");

        for (int i = 0; i < n - 1; i++)
        {
            // Mostramos los datos desordenados
            foreach (int dato in datos)
            {
                System.Console.Write("{0}, ", dato);
            }
            System.Console.WriteLine();//Salto de linea

            // Ordenamos datos
            for (int j = i + 1; j < n; j++)
            {

                if (datos[i] > datos[j])
                {
                    datoTemporal = datos[i];
                    datos[i] = datos[j];
                    datos[j] = datoTemporal;
                }
            }
        }
        // Mostramos datos ordenados
        System.Console.WriteLine();
        System.Console.WriteLine("Mostrando datos ordenados ");
        foreach (int dato in datos)
        {
            System.Console.Write("{0}, ", dato);
        }
        System.Console.WriteLine();// Sato de línea




    }
}