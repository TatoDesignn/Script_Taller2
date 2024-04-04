public delegate string HorariosClase();

public class Clases
{
    public string Lunes()
    {
        return "Calculo, Scripting, Taller";
    }

    public string Martes()
    {
        return "Vision, Computacionales";
    }

    public string Miercoles()
    {
        return "Fisicos";
    }

    public string Jueves()
    {
        return "Mecanismos, Expirementales";
    }

    public string Viernes()
    {
        return "Algebra, Scripting, Interfaces";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Clases horario = new Clases();

        HorariosClase clases = horario.Lunes;
        Console.WriteLine(clases());

        clases = horario.Martes;
        Console.WriteLine(clases());

        clases = horario.Miercoles;
        Console.WriteLine(clases());

        clases = horario.Jueves;
        Console.WriteLine(clases());

        clases = horario.Viernes;
        Console.WriteLine(clases());
    }
}

