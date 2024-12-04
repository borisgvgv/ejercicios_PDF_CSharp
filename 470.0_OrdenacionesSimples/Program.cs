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


        // -------------- Metodo de selección directa--------------------

        int[] datosDos = { 5, 3, 14, 20, 8, 9, 1 };
        int menor;

        System.Console.WriteLine();
        System.Console.WriteLine("Ordenando datos con el método de selección directa");

        for (int i = 0; i < n - 1; i++)
        {

            // Muestro datos desordenados
            foreach (int dato in datosDos)
            {
                System.Console.Write($"{dato}, ");
            }
            System.Console.WriteLine();


            menor = i;

            for (int j = i + 1; j < n; j++)
            {
                if (datosDos[j] < datosDos[menor])
                {
                    menor = j;
                }
                //System.Console.WriteLine($"{menor}-{datosDos[menor]}");
            }

            if (i != menor)
            {
                datoTemporal = datosDos[i];
                datosDos[i] = datosDos[menor];
                datosDos[menor] = datoTemporal;
            }

        }
        System.Console.WriteLine();

        System.Console.WriteLine("Datos ordenados");
        foreach (int dato in datosDos)
        {
            System.Console.Write($"{dato}, ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("Ordenando datos con el método Inserción directa");
        int[] datos3 = { 5, 3, 14, 20, 8, 9, 1 };
        for (int i = 1; i < n; i++)
        {
            foreach (int dato in datos3) // Muestro datos
                Console.Write("{0} ", dato);
            Console.WriteLine();

            int j = i - 1;
           // System.Console.WriteLine($"Comparamos si: {datos3[j]} > {datos3[j+1]}");
            while ((j >= 0) && (datos3[j] > datos3[j + 1]))
            {
                datoTemporal = datos3[j];
                datos3[j] = datos3[j + 1];
                datos3[j + 1] = datoTemporal;
                j--;
               // System.Console.WriteLine($"Luego de comparar restamos j-1 = {j}");
            }
        }
        System.Console.WriteLine();
                        
        Console.WriteLine("Ordenado:");
        foreach (int dato in datos3) // Muestro datos finales
            Console.Write("{0} ", dato);
        Console.WriteLine();


    }
}