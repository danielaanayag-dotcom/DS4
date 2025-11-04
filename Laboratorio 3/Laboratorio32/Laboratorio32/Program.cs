internal class Program
{
    private static void Main(string[] args)
    {
        int radio;

        Console.WriteLine("Introduce el radio del círculo: ");
        radio = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calculo = new CalculosMatematicos();

        Console.WriteLine("El área del círculo es: " + calculo.AreaCirculo(radio));

    }
}

class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }

public double AreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}
}