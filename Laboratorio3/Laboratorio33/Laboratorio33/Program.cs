internal class Program
{
    private static void Main(string[] args)
    {
        double largo, anchura, perimetro;

        Console.Write("Introduce el largo del rectangulo: ");
        largo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la anchura del rectangulo: ");
        anchura = Convert.ToDouble(Console.ReadLine());

        perimetro = 2*(largo+anchura);

        Console.WriteLine("El perímetro del rectángulo es: " + (perimetro));
    }
}