using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
namespace Prog1_Practica_Git_PettinatiMartinez;

    public class Veterinaria
    {
        private List <Mascota> Mascotas = new List<Mascota>();

        public Veterinaria()
    {
        Mascotas = new List<Mascota>();
    }

        public Mascota RegistrarMascota(Mascota mascota)
    {
        Mascotas.Add(mascota);

        return mascota;
    }

        public string MostrarTodas()
    {
        
string resultado = "";
        if (Mascotas.Count == 0)
        {
            return "No hay";
        } else
        {

            foreach (var mascota in Mascotas)
            {
                resultado += $"Mascota: {mascota.ObtenerInfo()}";
            }
        }
        return resultado;
    }

    }
