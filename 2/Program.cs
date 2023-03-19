using System;

class Rectangulo // Define una clase llamada Rectangulo.
{
    static void Main(string[] args) // Define el método Main, el punto de entrada de la aplicación.
    {
        // Escribe en la consola pidiendo al usuario que ingrese el ancho del rectángulo.
        Console.WriteLine("Ingrese el ancho del rectángulo:"); 

        // Lee el valor ingresado por el usuario, convierte ese valor a tipo double y lo guarda en la variable "ancho".
        double ancho = Convert.ToDouble(Console.ReadLine()); 

        // Escribe en la consola pidiendo al usuario que ingrese la altura del rectángulo.
        Console.WriteLine("Ingrese la altura del rectángulo:"); 

        // Lee el valor ingresado por el usuario, convierte ese valor a tipo double y lo guarda en la variable "altura".
        double altura = Convert.ToDouble(Console.ReadLine()); 

        // Llama a la función CalcularPerimetroRectangulo con los valores de "ancho" y "altura" y guarda el resultado en la variable "perimetro".
        double perimetro = CalcularPerimetroRectangulo(ancho, altura); 

        // Escribe en la consola el perímetro del rectángulo calculado.
        Console.WriteLine("El perímetro del rectángulo es: " + perimetro); 
    }

        // Define una función llamada CalcularPerimetroRectangulo que recibe dos parámetros de tipo double llamados "ancho" y "altura".
        static double CalcularPerimetroRectangulo(double ancho, double altura) 
    {
        // Calcula el perímetro del rectángulo usando la fórmula del perímetro y guarda el resultado en la variable "perimetro".
        double perimetro = 2 * (ancho + altura); 

        // Retorna el valor calculado del perímetro del rectángulo.
        return perimetro; 
    }
}