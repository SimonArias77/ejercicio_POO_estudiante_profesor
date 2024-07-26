using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_POO_profesor_estudiante.Models;

public class Estudiante: Persona 
{
    // creamos las propiedades de la clase

    public string NombreAcudiente { get; set; }
    public string CursoActual { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public List<double> Calificaciones { get; set; }

    // creamos el constructor

    public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono,string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento, string direccion, List<double> calificaciones): base( nombre,  apellido,  tipoDocumento,  numeroDocumento,  email,  telefono)
    {
      
    }

    // creamos los métodos de la clase

    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre acudiente: {NombreAcudiente}");
        Console.WriteLine($"Curso actual: {CursoActual}");
        Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento.ToString("dd/MM/yyyy")}");
        Console.WriteLine("Calificaciones:");
        foreach (var calificacion in Calificaciones)
        {
            Console.WriteLine(calificacion);
        }
        CalcularPromedio();
        Console.WriteLine($"Edad: {CalcularEdad()} años");
    }

    public void AgregarCalificaciones()
    {
        Console.WriteLine("por favor agregue las calificaciones");
    }

    private void CalcularPromedio()
    {
        double suma = Calificaciones.Sum();
        double promedio = suma / Calificaciones.Count;
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }

    public int CalcularEdad()
    {
        int edad = DateTime.Today.Year - FechaNacimiento.Year;
        if (DateTime.Today.Month < FechaNacimiento.Month || (DateTime.Today.Month == FechaNacimiento.Month && DateTime.Today.Day < FechaNacimiento.Day))
        {
            edad--;
        }
        return edad;
    }
}
