internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;

        Console.WriteLine("Introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calculo = new CalculosMatematicos();

        int resultado = calculo.Calcular(primerNumero, segundoNumero);

        Console.WriteLine("El resultado de ({0} + {1}) * ({0} - {1}) es: {2}", primerNumero, segundoNumero, resultado);

    }
}

class CalculosMatematicos
{
    public int Calcular (int a, int b)
    {
        return (a + b) * (a - b);
    }
}