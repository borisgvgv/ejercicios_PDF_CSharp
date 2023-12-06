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

1 - Añadir un nuevo curso (al final de los datos existentes). Ni el nombre ni la fecha deben estar vacíos. Si se introduce una 
cadena vacía para la duración, ésta se guardará como 10. No se pedirá si está terminado, sino que se dará por sentado que no es así.

2 - Ver cursos no terminados, mirando el correspondiente campo booleano. 
Debe mostrar el número de registro (contando desde 1), el nombre, la fecha y la duración, 
en la misma línea, haciendo una pausa después de cada 22 líneas en pantalla.

3 - Marcar un curso como terminado, a partir de su número de registro. 
Se le debe avisar (pero no volver a preguntar) si introduce un número de registro 
incorrecto (no existente). Debe mostrar los datos del curso que se va a marcar como 
terminado y solicitar confirmación antes de hacerlo.

4 - Buscar cursos que contengan un determinado texto (búsqueda parcial, en el nombre o en la fecha,
sin distinción de mayúsculas y minúsculas). Debe mostrar el número de registro, el nombre, 
la fecha de comienzo y la duración, en la misma línea, haciendo una pausa después de cada 22 líneas en pantalla.

5 - Modificar un registro: pedirá al usuario su número (por ejemplo, 1 para la primera ficha), mostrará el valor anterior de cada campo (por ejemplo, dirá: "Nombre anterior: Ejercicios de programación") y permitirá escribir un nuevo valor para ese campo, o bien pulsar Intro para dejarlo sin modificar. Se debe avisar al usuario (pero no volver a pedir) si introduce un número de registro incorrecto. El campo "terminado" no se modificará.

6 - Borrar un registro, en la posición indicada por el usuario. Se le debe avisar (pero no volver a preguntar) si introduce un número de registro incorrecto. Debe mostrar el registro que se va a eliminar y solicitar confirmación antes de la eliminación.

7 - Ordenar los datos. Se preguntará al usuario si desea ordenar por nombre del curso (alfabéticamente, de la A a la Z) o por fecha (descendente, del curso más reciente al más antiguo). En caso de ordenar por fecha, si coincide la fecha de 2 o más cursos, éstos se ordenarán de menor a mayor cantidad de horas.

S - Salir de la aplicación (como no guardamos la información en fichero, los datos se perderán).


El menú deberá repetirse hasta que el usuario escoja la opción "S" (que será aceptable tanto en mayúsculas como en minúsculas).


La estructura repetitiva del programa debe ser adecuada, y emplear un booleano de control. El fuente debe estar correctamente tabulado y resultar fácil de leer.

Debes entregar exclusivamente el fichero ".cs" (no todo el proyecto), sin comprimir, que deberá tener un comentario con tu nombre al principio. Haz que el nombre del fichero también incluya tu nombre.

*/


using System;
using System.Text;
class ENprueba
{
    struct Curso
    {
        public string? nombreCurso;
        public string? fechaComienzo;
        public float horasCurso;
        public string? estadoDelCurso;
        public bool terminado;
        public int registro;

    }
    static void Main()
    {

        const int numeroDeCursos = 5000;
        string? opcion = "";
        string? confirmacion = "";
        Curso[] cursos = new Curso[numeroDeCursos];

        int cantidadCursos = 0;
        int registro = 1;
        int cantidadLineas = 0;
        //cursos[cantidadCursos].horasCurso = 10;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Elige una opción del menú");
            Console.WriteLine("1. Añadir un curso.");
            Console.WriteLine("2. Ver cursos no terminados.");
            Console.WriteLine("3. Marcar un curso como terminado.");
            Console.WriteLine("4. Buscar entre los cursos existentes.");
            Console.WriteLine("5. Modificar los datos de un curso.");
            Console.WriteLine("6. Borrar un curso.");
            Console.WriteLine("7. Ordenar datos.");
            Console.WriteLine("s. Salir.");

            opcion = Console.ReadLine();

            if (opcion == "s")
            {
                opcion = "s".ToUpper();
            }

            switch (opcion)
            {
                case "1":

                    Console.WriteLine("opcion 1: Añadir un curso.");
                    if (cantidadCursos < numeroDeCursos)
                    {

                        cursos[cantidadCursos].terminado = false;
                        cursos[cantidadCursos].registro = registro; // Asignamos registro del curso

                        do
                        {
                            Console.Write("Nombre del curso: ");
                            cursos[cantidadCursos].nombreCurso = Console.ReadLine();
                        } while (cursos[cantidadCursos].nombreCurso == "");

                        do
                        {
                            Console.Write("Fecha de inicio del curso: ");
                            cursos[cantidadCursos].fechaComienzo = Console.ReadLine();
                        } while (cursos[cantidadCursos].fechaComienzo == "");

                        Console.Write("Horas del curso: ");
                        try
                        {
                            cursos[cantidadCursos].horasCurso = Convert.ToSingle(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            cursos[cantidadCursos].horasCurso = 10;
                        }

                        //Console.Write("Terminado o activo: ");

                        cursos[cantidadCursos].estadoDelCurso = "Activo";

                        registro++;
                        //Añadimos una ficha más
                        cantidadCursos++;
                    }

                    break;

                case "2":
                    Console.WriteLine("opcion 2: Ver cursos no terminados.");
                    Console.WriteLine(); //Salto de línea


                  do{
                        for (int i = cantidadLineas; i < cantidadCursos; i++)
                        {
                            if ((!cursos[i].terminado) && (i <= cantidadLineas + 2))
                            {
                                Console.WriteLine("Número de registro: {0}, Nombre del curso: {1}, Fecha de inicio: {2}, Horas de duración: {3}", cursos[i].registro, cursos[i].nombreCurso, cursos[i].fechaComienzo, cursos[i].horasCurso);
                                Console.WriteLine("Estado: {0}", cursos[i].estadoDelCurso);
                                Console.WriteLine(); //Salto de línea

                            }
                            cantidadLineas ++;
                        }

                         Console.Write("Siguiente o Enter para salir");
                                string opcionVer = Console.ReadLine();
                       
                        
                    } while (Console.ReadKey().Key != ConsoleKey.Enter);

                    break;
                case "3":
                    Console.WriteLine("opcion 3: Marcar un curso como terminado.");
                    Console.WriteLine(); //Salto de línea


                    try
                    {
                        Console.Write("Registro del curso a modificar: ");
                        int cursoModificar = Convert.ToInt32(Console.ReadLine());
                        cursoModificar--;

                        if ((cursos[cursoModificar].registro > 0) && (cursos[cursoModificar].registro <= cantidadCursos))
                        {
                            Console.WriteLine("Número de registro: {0}, Nombre del curso: {1}, Fecha de inicio: {2}, Horas de duración: {3}", cursos[cursoModificar].registro, cursos[cursoModificar].nombreCurso, cursos[cursoModificar].fechaComienzo, cursos[cursoModificar].horasCurso);
                            Console.WriteLine("Estado: {0}", cursos[cursoModificar].estadoDelCurso);
                            Console.WriteLine(); //Salto de línea
                            Console.Write("Escriba si o no para confirmar el cambio de estado: ");
                            confirmacion = Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("No existente");

                        }

                        if (confirmacion == "si")
                        {

                            cursos[cursoModificar].terminado = true;

                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("No existente");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debes marcar el registro del curso");
                    }


                    Console.WriteLine(); //Salto de línea
                    break;

                case "4":
                    Console.WriteLine("opcion 4: Buscar entre los cursos existentes.");
                    Console.WriteLine(); //Salto de línea

                    Console.Write("Nombre o fecha del curso a buscar: ");
                    string? nombreCursoBuscar = Console.ReadLine();

                    bool existe = false;

                    for (int i = 0; i < cantidadCursos; i++)
                    {
                        if (nombreCursoBuscar.ToUpper() == cursos[i].nombreCurso.ToUpper())
                        {
                            Console.WriteLine("Número de registro: {0}, Nombre del curso: {1}, Fecha de inicio: {2}, Horas de duración: {3}", cursos[i].registro, cursos[i].nombreCurso, cursos[i].fechaComienzo, cursos[i].horasCurso);
                            Console.WriteLine("Estado: {0}", cursos[i].estadoDelCurso);
                            existe = true;
                        }

                        else if (nombreCursoBuscar == cursos[i].fechaComienzo)
                        {
                            Console.WriteLine("Número de registro: {0}, Nombre del curso: {1}, Fecha de inicio: {2}, Horas de duración: {3}", cursos[i].registro, cursos[i].nombreCurso, cursos[i].fechaComienzo, cursos[i].horasCurso);
                            Console.WriteLine("Estado: {0}", cursos[i].estadoDelCurso);
                            existe = true;
                        }


                    }
                    if (existe == false)
                    {
                        Console.WriteLine("Nombre o fecha incorrecto");
                    }

                    Console.WriteLine(); //Salto de línea
                    break;

                case "5":
                    Console.WriteLine("opcion 5: Modificar los datos de un curso.");
                    Console.WriteLine(); //Salto de línea



                    Console.Write("Registro del curso a modificar: ");
                    int registroCursoModificar = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < cantidadCursos; i++)
                    {
                        if (registroCursoModificar == cursos[i].registro)
                        {

                            do
                            {
                                Console.WriteLine("Nombre anterior: {0}", cursos[i].nombreCurso);
                                Console.WriteLine("Escribir nuevo nombre o Enter para dejarlo sin modificar: ");
                                cursos[i].nombreCurso = Console.ReadLine();

                            } while ((cursos[cantidadCursos].nombreCurso == "") || (Console.ReadKey().Key != ConsoleKey.Enter));


                            do
                            {
                                Console.WriteLine("Fecha anterior: {0}", cursos[i].fechaComienzo);
                                Console.WriteLine("Escribir nueva fecha o Enter para dejarlo sin modificar: ");
                                Console.Write("Fecha de inicio del curso: ");
                                cursos[i].fechaComienzo = Console.ReadLine();

                            } while ((cursos[cantidadCursos].fechaComienzo == "") || (Console.ReadKey().Key != ConsoleKey.Enter));


                            do
                            {
                                Console.WriteLine("Hora anterior: {0}", cursos[i].horasCurso);
                                Console.WriteLine("Escribir nueva hora o Enter para dejarlo sin modificar: ");
                                Console.Write("Horas del curso: ");
                                try
                                {
                                    cursos[i].horasCurso = Convert.ToSingle(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    cursos[i].horasCurso = cursos[i].horasCurso;
                                }



                            } while (Console.ReadKey().Key != ConsoleKey.Enter);

                        }

                    }
                    Console.WriteLine(); //Salto de línea
                    break;

                case "6":
                    Console.WriteLine("opcion 6: Borrar un curso.");
                    Console.WriteLine(); //Salto de línea
                    Console.Write("Registro del curso a borrar: ");
                    int cursoBorrar = Convert.ToInt32(Console.ReadLine());
                    bool borrar = false;
                    for (int i = 0; i < cantidadCursos; i++)
                    {
                        if (cursoBorrar == cursos[i].registro)
                        {
                            borrar = true;
                            Console.WriteLine("Has elegido para borrar el registro {0}", cursos[i].registro);
                            Console.WriteLine("Escribir si o Enter para dejarlo sin modificar: ");
                            string si = Console.ReadLine();
                            if (si == "si")
                            {
                                cursos[i] = cursos[i + 1];
                                cantidadCursos--;
                            }

                        }
                    }

                    if (borrar == false)
                    {
                        Console.WriteLine("Registro a borrar no encontrado");
                    }

                    Console.WriteLine(); //Salto de línea
                    break;

                case "7":
                    Console.WriteLine("opcion 7: Ordenar datos.");

                    Console.Write("Organizar por: nombre o fecha: ");
                    string ordenarPor = Console.ReadLine();

                    ordenarPor = ordenarPor.ToUpper();
                    if (ordenarPor == "NOMBRE")
                    {
                        for (int i = 0; i < cantidadCursos; i++)
                        {
                            for (int j = i + 1; j < cantidadCursos; j++)
                            {
                                if (String.Compare(cursos[j].nombreCurso, cursos[i].nombreCurso, true) < 0)
                                {

                                    Curso nombremayor = cursos[i];
                                    cursos[i] = cursos[j];
                                    cursos[j] = nombremayor;
                                }
                            }

                            Console.WriteLine("Número de registro: {0}, Nombre del curso: {1}, Fecha de inicio: {2}, Horas de duración: {3}", cursos[i].registro, cursos[i].nombreCurso, cursos[i].fechaComienzo, cursos[i].horasCurso);
                            Console.WriteLine("Estado: {0}", cursos[i].estadoDelCurso);
                        }
                    }
                    else if (ordenarPor == "FECHA")
                    {

                        for (int i = 0; i < cantidadCursos; i++)
                        {
                            for (int j = i + 1; j < cantidadCursos; j++)
                            {

                                if (String.Compare(cursos[j].fechaComienzo, cursos[i].fechaComienzo, true) == 0)
                                {
                                    if (cursos[j].horasCurso < cursos[i].horasCurso)
                                    {
                                        Curso horas = cursos[i];
                                        cursos[i] = cursos[j];
                                        cursos[j] = horas;

                                    }
                                }
                                else if ((String.Compare(cursos[j].fechaComienzo, cursos[i].fechaComienzo, true) > 0) && (String.Compare(cursos[j].fechaComienzo, cursos[i].fechaComienzo, true) != 0))
                                {
                                    Curso fechamenor = cursos[i];
                                    cursos[i] = cursos[j];
                                    cursos[j] = fechamenor;
                                }

                            }

                            Console.WriteLine("Número de registro: {0}, Nombre del curso: {1}, Fecha de inicio: {2}, Horas de duración: {3}", cursos[i].registro, cursos[i].nombreCurso, cursos[i].fechaComienzo, cursos[i].horasCurso);
                            Console.WriteLine("Estado: {0}", cursos[i].estadoDelCurso);
                        }

                    }
                    break;

                case "S":

                    Console.WriteLine("Has elegido la opcion salir");
                    break;

                default: Console.WriteLine("Opción desconocida"); break;

            }

        } while (opcion != "S");

    }
}
