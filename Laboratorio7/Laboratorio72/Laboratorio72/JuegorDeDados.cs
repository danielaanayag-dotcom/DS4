using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JuegorDeDados
{
    private dado dado1, dado2, dado3;

    public JuegorDeDados()
    {
        dado1 = new dado();
        dado2 = new dado();
        dado3 = new dado();
    }

    public void Jugar()
    {
        dado1.Tirar();
        dado1.Imprimir();
        dado2.Tirar();
        dado2.Imprimir();
        dado3.Tirar();
        dado3.Imprimir();

        if(dado1.RetornarValor() == dado2.RetornarValor() &&
            dado1.RetornarValor() == dado3.RetornarValor())
        {
            Console.WriteLine("Ganó");
        }
        else
        {
            Console.WriteLine("Perdió");
        }
        Console.ReadKey();

    }
}
    

