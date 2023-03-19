using System;

class DistanciaPuntos // Define una clase llamada DistanciaPuntos.
{
    static void Main(string[] args) // Define el método Main, el punto de entrada de la aplicación.
    {
        // Escribe en la consola pidiendo al usuario que ingrese la coordenada x del primer punto.
        Console.WriteLine("Ingrese la coordenada x del primer punto:"); 
        
        // Lee el valor ingresado por el usuario, convierte ese valor a tipo double y lo guarda en la variable "x1".
        double x1 = Convert.ToDouble(Console.ReadLine()); 

        // Escribe en la consola pidiendo al usuario que ingrese la coordenada y del primer punto.
        Console.WriteLine("Ingrese la coordenada y del primer punto:"); 

        // Lee el valor ingresado por el usuario, convierte ese valor a tipo double y lo guarda en la variable "y1".
        double y1 = Convert.ToDouble(Console.ReadLine()); 

        // Escribe en la consola pidiendo al usuario que ingrese la coordenada x del segundo punto.
        Console.WriteLine("Ingrese la coordenada x del segundo punto:");
        
        // Lee el valor ingresado por el usuario, convierte ese valor a tipo double y lo guarda en la variable "x2".
        double x2 = Convert.ToDouble(Console.ReadLine()); 

        // Escribe en la consola pidiendo al usuario que ingrese la coordenada y del segundo punto.
        Console.WriteLine("Ingrese la coordenada y del segundo punto:"); 

        // Lee el valor ingresado por el usuario, convierte ese valor a tipo double y lo guarda en la variable "y2".
        double y2 = Convert.ToDouble(Console.ReadLine()); 

        // Llama a la función CalcularDistancia con los valores de las coordenadas x e y de ambos puntos y guarda el resultado en la variable "distancia".
        double distancia = CalcularDistancia(x1, y1, x2, y2); 

        // Escribe en la consola la distancia entre los dos puntos calculada.
        Console.WriteLine("La distancia entre los dos puntos es: " + distancia); 
    }
        // Define una función llamada CalcularDistancia que recibe cuatro parámetros de tipo double: "x1", "y1", "x2" y "y2".
    static double CalcularDistancia(double x1, double y1, double x2, double y2) 
    {
        // Calcula la diferencia en el eje x entre los dos puntos y guarda el resultado en la variable "deltaX".
        double deltaX = x2 - x1; 
        // Calcula la diferencia en el eje y entre los dos puntos y guarda el resultado en la variable "deltaY".
        double deltaY = y2 - y1; 

        // Calcula la distancia entre los dos puntos utilizando el teorema de Pitágoras y guarda el resultado en la variable "distancia".
        double distancia = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2)); 
        // Retorna el valor calculado de la distancia entre los dos puntos.
        return distancia; 
    }
}
