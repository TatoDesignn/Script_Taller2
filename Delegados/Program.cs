public delegate string HorariosClase();
public delegate void Saludo();

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

        clases += horario.Martes;
        clases += horario.Miercoles;
        clases += horario.Jueves;
        clases += horario.Viernes;

        foreach (HorariosClase horarioClase in clases.GetInvocationList())
        {
            Console.WriteLine(horarioClase());
        }
    }
}

