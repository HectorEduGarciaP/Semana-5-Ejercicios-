using System; 
class Program 
{
    static void Main(string[] args) // Define el método Main, el punto de entrada de la aplicación.
    {
        // Escribe en la consola pidiendo al usuario que ingrese el radio del círculo.
        Console.WriteLine("Ingrese el radio del círculo:"); 

        // Lee el valor ingresado por el usuario, convierte ese valor a tipo double y lo guarda en la variable "radio".
        double radio = Convert.ToDouble(Console.ReadLine()); 

        // Llama a la función CalcularAreaCirculo con el valor de "radio" y guarda el resultado en la variable "area".
        double area = CalcularAreaCirculo(radio); 

        Console.WriteLine("El área del círculo es: " + area); // Escribe en la consola el área del círculo calculada.
    }

    static double CalcularAreaCirculo(double radio) // Define una función llamada CalcularAreaCirculo que recibe un parámetro de tipo double llamado "radio".
    {
        // Define una constante llamada PI y le asigna un valor aproximado.
        const double PI = 3.141592653589793238; 

        // Calcula el área del círculo usando la fórmula del área y guarda el resultado en la variable "area".
        double area = PI * Math.Pow(radio, 2); 

        // Retorna el valor calculado del área del círculo.
        return area; 
    }
}
