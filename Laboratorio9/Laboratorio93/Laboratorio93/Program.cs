internal class Program
{
    public class Triangulo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 3 lados del triangulo (A, B, C): ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());    
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                string tipo = (a == b && b == c) ? "EQUILÁTERO" : (a == b || a == c || b == c) ? "ISÓSCELES" : "ESCALENO";

                Console.WriteLine(tipo);
            }
            else
            {
                Console.WriteLine("Error!, Los lados NO forman un triángulo.");
            }
        }
    }
}