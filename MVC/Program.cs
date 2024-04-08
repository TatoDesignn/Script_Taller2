
public class Usuario
{
    public string Email { get; set; }
    public string contrasena { get; set; }
}

public class Vista
{
    public void MostrarDatos(Usuario usuario)
    {
        Console.WriteLine($"Email: {usuario.Email}");
        Console.WriteLine($"Contraseña: {usuario.contrasena}");
    }
}

public class Controlador
{
    private Usuario usuario;
    private Vista vista;

    public Controlador(Usuario usuario, Vista vista)
    {
        this.usuario = usuario;
        this.vista = vista;
    }

    public void ActualizarDatos(string email, string contrasena)
    {
        usuario.Email = email;
        usuario.contrasena = contrasena;
    }

    public void MostrarDatos()
    {
        vista.MostrarDatos(usuario);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario();
        Vista vista = new Vista();
        Controlador controlador = new Controlador(usuario, vista);

        controlador.ActualizarDatos("pepito@hotmail.com", "hola123");
        controlador.MostrarDatos();
    }
}