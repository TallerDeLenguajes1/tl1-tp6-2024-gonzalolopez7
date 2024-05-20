# tl1-tp6-2024-gonzalolopez7

## ejercicio 4

string es un tipo por referencia. tiene secuencias de escape como:
    - '\n' salto de linea
    - '\t' tabulacion
    - '\b' retroceso
    - '\a' alerta
    - '\f' avance de pagina

El carácter @ antes de una cadena de texto en C# se utiliza para crear cadenas literales. O sea, las secuencias de escape se mostraran como texto y no cumplirán ninguna funcion.

Se usa $ para crear cadenas interpoladas, es decir, para poder insertar expresiones dentro de la cadena que el compilador JIT reemplazara por el valor de dicha expresión. Por ejemplo, $"Hola, {nombre}" reemplazará {nombre} con el valor de la variable nombre.