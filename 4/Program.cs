using System;

class ParImpar // Define una clase llamada ParImpar.
{
    static void Main(string[] args) // Define el método Main, el punto de entrada de la aplicación.
    {
        // Escribe en la consola pidiendo al usuario que ingrese un número entero.
        Console.WriteLine("Ingrese un número entero:"); 

        // Lee el valor ingresado por el usuario, convierte ese valor a tipo int y lo guarda en la variable "numero".
        int numero = Convert.ToInt32(Console.ReadLine()); 

        // Llama a la función EsPar con el valor de "numero" y guarda el resultado en la variable "esPar".
        bool esPar = EsPar(numero); 

        // Si "esPar" es verdadero (el número es par)...
        if (esPar) 
        {

        // Escribe en la consola que el número es par.
            Console.WriteLine("El número es par."); 
        }

        else // Si "esPar" es falso (el número no es par)...
        {
            Console.WriteLine("El número es impar."); // Escribe en la consola que el número es impar.
        }
    }

    static bool EsPar(int numero) // Define una función llamada EsPar que recibe un parámetro de tipo int llamado "numero".
    {
    // Calcula si el número es par usando el operador módulo (%). Si el resto de la división entre "numero"
    // y 2 es igual a 0, entonces el número es par. Guarda el resultado en la variable "par".
        bool par = numero % 2 == 0; 

        return par; // Retorna el valor de la variable "par" (verdadero si el número es par, falso si el número es impar).
    }
}
