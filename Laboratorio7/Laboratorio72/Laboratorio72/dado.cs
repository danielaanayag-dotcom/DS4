using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class dado
{
    private int valor;
    private static Random aleatorio;

    public dado()
    {
        aleatorio = new Random();
    }

    public void Tirar()
    {
        valor = aleatorio.Next(1, 7);
    }

    public void Imprimir()
    {
        Console.WriteLine("El valor del dado es:" + valor);
    }

    public int RetornarValor()
    {
        return valor;
    }
}
