Hola, en este programa implementé dos métodos de búsqueda: búsqueda lineal y búsqueda binaria en C#.

Primero, el programa muestra un arreglo ordenado de números:
2, 5, 8, 12, 16, 23, 38, 56, 72, 91.

Luego el usuario ingresa un número que desea buscar.

La búsqueda lineal recorre el arreglo elemento por elemento desde el inicio hasta el final, comparando cada valor con el número buscado.
Si lo encuentra, devuelve la posición.
Si no lo encuentra, devuelve -1.

Este método tiene una complejidad de O(n), porque en el peor caso debe recorrer todo el arreglo.

La búsqueda binaria, en cambio, solo funciona cuando el arreglo está ordenado.
Este método divide el arreglo en mitades.
Primero compara el valor del centro.
Si el número buscado es mayor, busca en la mitad derecha.
Si es menor, busca en la mitad izquierda.

Este proceso se repite hasta encontrar el número o hasta que el rango se reduzca a cero.

La búsqueda binaria tiene una complejidad de O(log n), por lo que es más eficiente que la búsqueda lineal cuando el arreglo está ordenado.

Por eso, para grandes cantidades de datos, la búsqueda binaria es más rápida.
