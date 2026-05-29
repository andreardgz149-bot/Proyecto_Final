using Proyectof.Strategies;
namespace Proyectof.Models;
public class Jugador
{
//Atributos 
public string Nombre { get; set; }
public required IJugada JugadaActual { get; set; }

//Constructor
public Jugador(string nombre )
{
    Nombre = nombre;
}

//Métodos
public void ElegirJugada(IJugada jugada)
{
JugadaActual = jugada;
}

}