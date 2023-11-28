/*
Ejercicio con nota 2 (tema 4) - Noviembre 2023

Vamos a crear un programa en C# para gestionar los cursos de una academia. El programa estará preparado para que pueda almacenar hasta 5000 cursos. 

Para cada curso, debe permitir al usuario almacenar la siguiente información:

    • Nombre del curso

    • Fecha comienzo (un texto como "2023-11-22")

    • Horas de duración (un número entre 5 y 50, quizá con un cifra decimal, como en 12.5)

    • Terminado o no (booleano)


Esta versión mostrará un menú con las opciones:

1. Añadir un curso.

2. Ver cursos no terminados.

3. Marcar un curso como terminado.

4. Buscar entre los cursos existentes.

5. Modificar los datos de un curso.

6. Borrar un curso.

7. Ordenar datos.

S. Salir.


Es decir, debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un nuevo curso (al final de los datos existentes). Ni el nombre ni la fecha deben estar vacíos. Si se introduce una cadena vacía para la duración, ésta se guardará como 10. No se pedirá si está terminado, sino que se dará por sentado que no es así.

2 - Ver cursos no terminados, mirando el correspondiente campo booleano. Debe mostrar el número de registro (contando desde 1), el nombre, la fecha y la duración, en la misma línea, haciendo una pausa después de cada 22 líneas en pantalla.

3 - Marcar un curso como terminado, a partir de su número de registro. Se le debe avisar (pero no volver a preguntar) si introduce un número de registro incorrecto (no existente). Debe mostrar los datos del curso que se va a marcar como terminado y solicitar confirmación antes de hacerlo.

4 - Buscar cursos que contengan un determinado texto (búsqueda parcial, en el nombre o en la fecha, sin distinción de mayúsculas y minúsculas). Debe mostrar el número de registro, el nombre, la fecha de comienzo y la duración, en la misma línea, haciendo una pausa después de cada 22 líneas en pantalla.

5 - Modificar un registro: pedirá al usuario su número (por ejemplo, 1 para la primera ficha), mostrará el valor anterior de cada campo (por ejemplo, dirá: "Nombre anterior: Ejercicios de programación") y permitirá escribir un nuevo valor para ese campo, o bien pulsar Intro para dejarlo sin modificar. Se debe avisar al usuario (pero no volver a pedir) si introduce un número de registro incorrecto. El campo "terminado" no se modificará.

6 - Borrar un registro, en la posición indicada por el usuario. Se le debe avisar (pero no volver a preguntar) si introduce un número de registro incorrecto. Debe mostrar el registro que se va a eliminar y solicitar confirmación antes de la eliminación.

7 - Ordenar los datos. Se preguntará al usuario si desea ordenar por nombre del curso (alfabéticamente, de la A a la Z) o por fecha (descendente, del curso más reciente al más antiguo). En caso de ordenar por fecha, si coincide la fecha de 2 o más cursos, éstos se ordenarán de menor a mayor cantidad de horas.

S - Salir de la aplicación (como no guardamos la información en fichero, los datos se perderán).


El menú deberá repetirse hasta que el usuario escoja la opción "S" (que será aceptable tanto en mayúsculas como en minúsculas).


La estructura repetitiva del programa debe ser adecuada, y emplear un booleano de control. El fuente debe estar correctamente tabulado y resultar fácil de leer.

Debes entregar exclusivamente el fichero ".cs" (no todo el proyecto), sin comprimir, que deberá tener un comentario con tu nombre al principio. Haz que el nombre del fichero también incluya tu nombre.

*/

using System;
class ENprueba
{
    struct Curso
    {
        public string nombreCurso;
        public string fechaComienzo;
        public float horasCurso;
    }
    static void Main()
    {

        const int numeroDeCursos = 5000;
        string opcion = "";
        Curso[] cursos = new Curso[numeroDeCursos];
        int cantidadCursos = 0;


        do
        {
            Console.WriteLine("Elige una opción del menú");
            Console.WriteLine("1. Añadir un curso.");
            Console.WriteLine("1. 2. Ver cursos no terminados.");
            Console.WriteLine("3. Marcar un curso como terminado.");
            Console.WriteLine("4. Buscar entre los cursos existentes.");
            Console.WriteLine("5. Modificar los datos de un curso.");
            Console.WriteLine("6. Borrar un curso.");
            Console.WriteLine("7. Ordenar datos.");
            Console.WriteLine("S. Salir.");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("opcion 1");
                    if (cantidadCursos < numeroDeCursos)
                    {
                        Console.Write("Nombre del curso: ");
                        cursos[cantidadCursos].nombreCurso = Console.ReadLine();
                        Console.Write("Fecha de inicio del curso: ");
                        cursos[cantidadCursos].fechaComienzo = Console.ReadLine();
                        Console.Write("Horas del curso: ");
                        cursos[cantidadCursos].horasCurso = Convert.ToSingle(Console.ReadLine());
                        //Añadimos una ficha más
                        cantidadCursos++;
                    }
                    break;

                case "2":
                    Console.WriteLine("opcion 2");
                    for (int i = 0; i < cantidadCursos; i++)
                    {
                        Console.WriteLine(cursos[i].nombreCurso);
                        Console.WriteLine(cursos[i].fechaComienzo);
                        Console.WriteLine(cursos[i].horasCurso);
                    }
                    break;
                case "3":
                    Console.WriteLine("opcion 3");
                    break;
                case "4":
                    Console.WriteLine("opcion 4");
                    break;
                case "5":
                    Console.WriteLine("opcion 5");
                    break;
                case "6":
                    Console.WriteLine("opcion 6");
                    break;
                case "7":
                    Console.WriteLine("opcion 7");
                    break;
                case "s":
                    Console.WriteLine("opcion salir");
                    break;
                default: Console.WriteLine("Opción desconocida"); break;

            }
        } while (opcion != "s");

    }
}
