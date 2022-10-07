using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculosSimples
{
    public double Somar(double numero1, double numero2)
    {
        double soma = numero1 + numero2;
        return soma;
    }

    public double Subtrair(double numero1, double numero2)
    {
        double subtrai = numero1 - numero2;
        return subtrai;

    }
    public double Dividir(double numero1, double numero2)
    {
        double dividir = numero1 / numero2;
        return dividir;

    }
    public double Multiplicar(double numero1, double numero2)
    {
        double multiplica = numero1 * numero2;
        return multiplica;

    }
}