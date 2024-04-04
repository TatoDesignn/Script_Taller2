

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
        Console.WriteLine(resultado(1, 1));

        resultado = calc.Restar;
        Console.WriteLine(resultado(2, 1));

        resultado = calc.Multiplicar;
        Console.WriteLine(resultado(2, 2)); 

        resultado = calc.Dividir;
        Console.WriteLine(resultado(4, 2));
    }
}