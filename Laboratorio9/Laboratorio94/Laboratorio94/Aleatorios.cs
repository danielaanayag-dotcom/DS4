using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int NumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] ArregloEntre(int min, int max, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        for(int i = 0; i < cantidad; i++)
        {
            arreglo[i] = NumeroEntre(min, max);
        }
        return arreglo;
    }
}
