using System;

public class Persona{

string nombre;

public void SetNombre(string nuevoNombre){
    nombre = nuevoNombre;
}
public void Saludar(){
    Console.WriteLine($"Hola soy {nombre}");
}


}

public class PruebaPersona{
    
    public static void Main(){

        Persona p1 = new Persona();
        Persona p2 = new Persona();

        p1.SetNombre("Boris");
        p2.SetNombre("Nelson");
        p1.Saludar();
        p2.Saludar();
        
    }

}