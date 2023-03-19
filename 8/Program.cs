using System;

class Program
{
    static void Main(string[] args)
    {
        int resultado = Factorial(5);  // Llamamos a la función Factorial con el valor 5 y guardamos el resultado en una variable
        Console.WriteLine(resultado); // Imprimimos el resultado en la consola
    }

    static int Factorial(int n)
    {
        int resultado = 1;   // Inicializamos la variable 'resultado' en 1
        for (int i = 1; i <= n; i++)   // Iteramos sobre los números del 1 al n
        {
            resultado *= i;   // Multiplicamos cada número por el 'resultado'
        }
        return resultado;   // Devolvemos el valor del 'resultado'
    }
}