/*
El concepto de "polimorfismo" se refiere a que una misma función (un método)
puede tener varias formas, ya sea porque reciba distintos tipos de parámetros y/o
en distinta cantidad, o porque incluso se aplique a distintos objetos.

Existen dos tipos especialmente importantes de polimorfismo:
_ En nuestro último ejemplo (06_06a), los dos constructores "Puerta()" y
"Puerta(int ancho, int alto)", que se llaman igual pero reciben distintos
parámetros, y se comportan de forma que puede ser distinta, son ejemplos
de "sobrecarga" (también conocida como "polimorfismo ad-hoc"). Es un
tipo de polimorfismo en el que el compilador sabe en tiempo de
compilación a qué método se debe llamar.

_ El caso opuesto es el "polimorfismo puro", en el que un mismo método se
aplica a distintos objetos de una misma jerarquía (como el "MostrarEstado"
del ejemplo 06_05a, que se puede aplicar a una puerta o a un portón), y en
ese caso el compilador puede llegar a no ser capaz de saber en tiempo de
compilación a qué método se debe llamar, y lo tiene que descubrir en
tiempo de ejecución. Es algo que nos encontraremos un poco más
adelante, cuando hablemos de "funciones virtuales".
*/ 