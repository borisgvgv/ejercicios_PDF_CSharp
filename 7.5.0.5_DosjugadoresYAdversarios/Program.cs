using System;

public class Ejemplo_07_05e
{
    public static void Main()
    {
        // Crear primer jugador sin adversario
        Jugador j1 = new Jugador("Alice");

        // Crear segundo jugador y asignar a j1 como su adversario
        Jugador j2 = new Jugador("Bob", j1);

        // Mostrar relaciones
        j1.MostrarAdversario();
        j2.MostrarAdversario();
    }
}

// ------------------
public class Jugador
{
    protected Jugador adversario;
    protected string nombre;

    // Constructor de jugador sin adversario
    public Jugador(string nombre)
    {
        this.nombre = nombre;
    }

    // Constructor de jugador con adversario
    public Jugador(string nombre, Jugador adversario)
    {
        this.nombre = nombre;
        // this.adversario = adversario; // Esto no estaria bien porque dejaria a J1 sin Adversario

        // Lo sig es lo correcto "this" hace ref a el jugador con dos parámetros
        SetAdversario(adversario);// Bob.setAdversario(Alice)
        adversario.SetAdversario(this);// Alice.setAdversario(Bob)

    }

    public void SetAdversario(Jugador nuevoAdversario)
    {
        adversario = nuevoAdversario;
    }


    public void MostrarAdversario()
    {
        if (adversario != null)
            Console.WriteLine($"{nombre} tiene como adversario a {adversario.nombre}");
        else
            Console.WriteLine($"{nombre} no tiene adversario.");
    }
}
