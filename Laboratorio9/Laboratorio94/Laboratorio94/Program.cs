internal class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();
        Console.WriteLine("Numero entre 5 y 10: " + aleatorios.NumeroEntre(5, 10));

        int[] arreglo = aleatorios.ArregloEntre(1, 20, 5);
        Console.WriteLine("Arreglo aleatorio: " + string.Join(", ", arreglo));
    }
}