using System;

class ConvertirMayusculas // Define una clase llamada ConvertirMayusculas.
{
    static void Main(string[] args) // Define el método Main, el punto de entrada de la aplicación.
    {
        Console.WriteLine("Ingrese una cadena de texto:"); // Escribe en la consola pidiendo al usuario que ingrese una cadena de texto.
        string cadena = Console.ReadLine(); // Lee la cadena de texto ingresada por el usuario y la guarda en la variable "cadena".

        // Llama a la función ConvertirAMayusculas con el valor de "cadena" y guarda el resultado en la variable "cadenaMayusculas".
        string cadenaMayusculas = ConvertirAMayusculas(cadena); 

        Console.WriteLine("La cadena en mayúsculas es: " + cadenaMayusculas); // Escribe en la consola la cadena de texto en mayúsculas.
    }

    static string ConvertirAMayusculas(string texto) // Define una función llamada ConvertirAMayusculas que recibe un parámetro de tipo string llamado "texto".
    {
        // Convierte la cadena "texto" a mayúsculas utilizando el método ToUpper() y guarda el resultado en la variable "textoMayusculas".
        string textoMayusculas = texto.ToUpper(); 
        return textoMayusculas; // Retorna el valor de la variable "textoMayusculas", que contiene la cadena de texto en mayúsculas.
    }
}

