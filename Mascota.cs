namespace Prog1_Practica_Git_PettinatiMartinez;

public class Mascota
{
    public string Nombre {get;set;}
    public string Especie{get;set;}
    public int Edad{get;set;}
    public Dueno Dueno {get;set;}

        public Mascota(string nombre, string especie, int edad, Dueno dueno)
    {
        Nombre = nombre;
        Especie = especie;
        Edad = edad;
        Dueno = dueno;
    }

    public string ObtenerInfo()
    {
        return $"{Nombre} | {Especie} | {Edad} años | Dueño: {Dueno.Nombre}";
    }
}


