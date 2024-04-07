
public class ClaseSingleton
{
    public static readonly ClaseSingleton instance = new ClaseSingleton();

    private ClaseSingleton() { }

    public static ClaseSingleton ObtenerInstancia()
    {
        return instance;
    }

    public void Saludar()
    {
        Console.WriteLine("Hola mundo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClaseSingleton singleton = ClaseSingleton.ObtenerInstancia();

        singleton.Saludar();
    }
}
