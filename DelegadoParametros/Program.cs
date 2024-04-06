

public delegate int CalculadoraDel(int a , int b);

public class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Restar(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Dividir(int a, int b)
    {
        return a / b;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        CalculadoraDel resultado = calc.Sumar;
        resultado += calc.Restar;
        resultado += calc.Multiplicar;
        resultado += calc.Dividir;

        foreach(CalculadoraDel calculadora in resultado.GetInvocationList())
        {
            Console.WriteLine(calculadora(4,2));
        }
    }
}