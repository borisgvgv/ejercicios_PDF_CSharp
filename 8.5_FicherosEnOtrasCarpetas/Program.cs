/*
Buscar fichero:
string nombreFichero = "d:\\ejemplos\\ejemplo1.txt"; // Ruta absoluta
string nombreFichero2 = "..\\datos\\configuracion.txt"; // Ruta relativa

Como esta sintaxis puede llegar a resultar incómoda, en C# existe una alternativa:
podemos indicar una arroba (@) justo antes de abrir las comillas, y entonces no
será necesario delimitar los caracteres de control con doble barra invertida

string nombreFichero = @"d:\ejemplos\ejemplo1.txt"; // Ruta absoluta
string nombreFichero2 = @"..\datos\configuracion.txt"; // Ruta relativa

*/

