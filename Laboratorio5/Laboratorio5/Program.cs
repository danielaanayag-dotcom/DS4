internal class Program
{

    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[6];
        for (int f = 1; f <= 5; f++)
        {
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los aperarios \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.WriteLine("[" + sueldos[f] + "]");

        }
        Console.ReadKey();

    }

    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();

    }


}
