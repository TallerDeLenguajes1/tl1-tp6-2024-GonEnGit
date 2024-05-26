# Respuestas para Ejercicio 4

1. string o String ambos funcionan como alias del tipo System.String, es un tipo de referencia, lo que significa que no se
trabaja con el texto en si si no con una referencia a una secuencia de objetos de tipo char

2. Algunas secuencia de escape son:
   * \' : Imprimer un comilla simple en el texto
   * \" : Imprimer un comilla doble en el texto
   * \	: Imprimer un barra diagonal invertida en el texto
   * \0 : Null
   * \a : Reproduce un sonido de alerta
   * \b : Hace retroceder una palabra, borra un caracter si pasa por ensima
   * \f : Avance de página
   * \n : Salta al siguiente renglon
   * \r : Devuelve el carro al principio de la linea
   * \t : Incluye un tab horizontal
   * \v : Incluye un tab vertical

3. @ y $ en cadenas de texto
   * Usar @ antes de una linea de texto, la imprime literalmente, osea, ignora toda secuencia de escape e imprime una \ seguida de una letra.
   * $ es una forma mas eficiente de concatenar valores con texto, permite incluir una variable como parte de la linea de texto usando {}
    Ej: ($"El resultado es {resultado}.")
