using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        Aleatorio aleatorios = new Aleatorio();

        int[] arregloUnico = aleatorios.GenerarArregloNoRepetido();

        Console.WriteLine("Prueba del arreglo NO REPETIDO");
        Console.WriteLine("Arreglo generado: ");
        Console.WriteLine(string.Join(", ", arregloUnico));
    }
}