using System;

public class Persona{

    string nombre = "pndte";
    int edad;

    public string GetNombre(){
        return nombre;
    }
    
     public void SetNombre(string nuevoNombre){
        nombre = nuevoNombre;
    }
    public int GetEdad(){
        return edad;
    }
    
     public void SetEdad(int nuevaEdad){
        edad = nuevaEdad;
    }

    public void Saludar(){
        Console.WriteLine("Hola soy {0} y tengo {1} años", nombre, edad);
    }
}