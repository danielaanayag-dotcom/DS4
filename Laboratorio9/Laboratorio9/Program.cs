internal class Program
{
    public class Ventas
    {
        public static void Main(string[] args)
        {
            Console.Write("Introduce el precio del producto (ej: 100.25):");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la forma de pago: (efectivo o tarjeta) ");
            string formaPago = Console.ReadLine().ToLower();

            if (formaPago == "tarjeta")
            {
                Console.Write("Introduce el número de cuenta (16 dígitos): ");
                string numeroCuenta = Console.ReadLine();

                Console.WriteLine($"\nPrecio: {precio: C}");
                Console.WriteLine($"Forma de pago: {formaPago}");
                Console.WriteLine($"Cuenta: {numeroCuenta}");
            }
            else
            {
                Console.WriteLine($"\nPrecio: {precio:C}");
                Console.WriteLine($"Forma de pago: {formaPago}");
                Console.WriteLine("Pago en efectivo.");
            }
        }

    }
}