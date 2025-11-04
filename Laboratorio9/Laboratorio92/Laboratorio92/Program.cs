internal class Program
{
    public class Divisible
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.Write(i + "");
                }
            }
        }
    }
}