using System;

class Program{
    static void Main(){

        Documento documento = new Documento();
        Libro libro= new Libro();

        documento.SetDatos("Rayuela", 1970);
        documento.Mostrar();
        
   
        libro.SetDatos("El amor en los tiempos del colera", 1968);
        libro.SetPag(200);
        libro.Mostrar();
        
    }
}