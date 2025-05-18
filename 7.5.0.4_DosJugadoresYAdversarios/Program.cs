/*
Otra alternativa es que un Jugador le pueda decir a otro "yo soy tu adversario", y
ese "yo" equivaldrá a un "this". En general, eso simplificará el programa principal, a
cambio de complicar ligeramente las clases auxiliares:
*/

using System;
public class Ejemplo_07_05e
{
    public static void Main()
    {
        Jugador j1 = new Jugador(); // Creado sin más detalles
        Jugador j2 = new Jugador(j1); // Indicando su adversario.  

        /*
          Se crea j1 sin adversario.
          Luego se crea j2, pasando j1 como adversario.
          En el constructor de j2, se asigna:
          j2.adversario = j1
          y también: j1.adversario = j2
          Resultado: ¡j1 y j2 se tienen mutuamente como adversarios!
        */

    }
}
// -----------------------------------

/*
    Constructor por defecto. No hace nada. Puedes crear un jugador sin asignarle un adversario de inmediato.
*/
public class Jugador
{
    protected Jugador adversario;

    public Jugador()
    {
    }

    // -----------------------------------

    /*
        Este constructor recibe como argumento a otro jugador (el adversario).
        El jugador actual (el que se está construyendo) guarda al adversario que se le pasa.
        Y además, le dice al adversario que él también lo tenga como adversario.
    💡  De esta forma, se establece una relación bidireccional entre los dos jugadores
    */
    public Jugador(Jugador adversario)
    {

        // Mi adversario es el que me indican
        SetAdversario(adversario);
        // Y yo soy su adversario
        adversario.SetAdversario(this);
    }

    // -----------------------------------
    /*
        Método público para asignar o cambiar el adversario de un jugador.
    */
    public void SetAdversario(Jugador nuevoAdversario)
    {

        adversario = nuevoAdversario;
    }
}