using System;
using System.Collections.Generic;

class PromedioNumeros // Define una clase llamada PromedioNumeros.
{           
    static void Main(string[] args) // Define el método Main, el punto de entrada de la aplicación.
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 }; // Crea una lista de enteros llamada "numeros" y le asigna algunos valores.

    // Llama a la función CalcularPromedio con la lista "numeros" y guarda el resultado en la variable "promedio".
        double promedio = CalcularPromedio(numeros); 
        Console.WriteLine("El promedio de los números es: " + promedio); // Escribe en la consola el promedio de los números calculado.
    }
    // Define una función llamada CalcularPromedio que recibe un parámetro de tipo List<int> llamado "listaNumeros".
    static double CalcularPromedio(List<int> listaNumeros) 
    {
        int suma = 0; // Inicializa una variable llamada "suma" en 0 para almacenar la suma de los números en la lista.

        foreach (int numero in listaNumeros) // Itera sobre cada número en la lista "listaNumeros" usando una estructura foreach.
        {
            suma += numero; // Suma el número actual a la variable "suma".
        }
   // Calcula el promedio dividiendo la suma de los números entre la cantidad de números en la lista. Convierte "suma" a double para evitar la división entera.
        double promedio = (double)suma / listaNumeros.Count; 
        return promedio; // Retorna el valor calculado del promedio de los números en la lista.
    }
}
