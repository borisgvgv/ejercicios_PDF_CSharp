/*
(5.2.1) Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando
25 líneas en blanco. Crea también un "Main" que permita probarla.*/
using System;
using System.Data;
class Program{
    static void Main(){
        string borrar;
        Saludar();
        Console.WriteLine("Pulsa enter para Borrar");
        borrar = Console.ReadLine();
        Borrar(borrar);
        
    }

    static void Saludar(){
        Console.WriteLine("Hola aquí estoy saludando desde la función Saludar");
        Console.WriteLine("y luego la borramos con la función borrar dibujando 25 saltos de línea");
    }

    static void Borrar(string borrar){
        Console.Clear();
        for(int i = 0; i <= 5; i++)
        Console.WriteLine();  
    }

}