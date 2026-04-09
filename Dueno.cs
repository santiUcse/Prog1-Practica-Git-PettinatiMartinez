namespace Prog1_Practica_Git_PettinatiMartinez;

public class Dueno
{
    public string Nombre { get; set;}
    public string Telefono {get; set;}

    public Dueno (string nombre, string telefono){
        Nombre = nombre;
        Telefono = telefono;
    }

    public string ObtenerInfo()
    {
        return $"Nombre: {Nombre} | Telefono: {Telefono}";
    }
}
