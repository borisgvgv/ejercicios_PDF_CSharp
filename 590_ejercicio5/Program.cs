using System;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        int[] vector = { 1, 2, 3, 4, 5 };
        int desde = 0;
        int hasta = vector.Length - 1;

        int suma = SumaVector(vector, desde, hasta);

        Console.WriteLine($"La suma del vector desde la posición {desde} hasta la posición {hasta} es: {suma}");
    }

    static int SumaVector(int[] v, int desde, int hasta)
    {
        int mayor = desde;
        // Caso base: cuando desde es mayor que hasta, no hay elementos para sumar
        if (desde > hasta)
        {
            return 0;
        }
        // Caso recursivo: la suma de los elementos desde hasta hasta es igual al elemento en la posición 'desde'
        // más la suma de los elementos desde la siguiente posición hasta hasta
        else
        {
            if ( SumaVector(v, desde + 1, hasta) < v[desde])
                mayor = v[desde];
            return mayor;
        }
    }
}