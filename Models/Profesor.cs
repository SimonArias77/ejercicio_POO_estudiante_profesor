using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_POO_profesor_estudiante.Models;

public class Profesor : Persona
{
    // creamos las propiedades de la clase
    public string Asignatura { get; set; }
    private double Salario { get; set; }
    public DateTime FechaContratacion { get; set; }
    public List<string> Cursos { get; set; }

    // creamos el constructor
    public Profesor(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string asignatura, double salario, DateTime fechaContratacion, List<string> cursos) : base(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono)
    {
        Asignatura = asignatura;
        Salario = salario;
        FechaContratacion = fechaContratacion;
        Cursos = cursos;
    }

    // creamos los métodos de la clase

    public void MostrarDetallesP()
    {
        Console.WriteLine($"Asignatura: {Asignatura}");
        Console.WriteLine($"Salario: ${Salario}");
        Console.WriteLine($"Fecha de contratación: {FechaContratacion.ToString("dd/MM/yyyy")}");
        Console.WriteLine("Cursos en los que imparte:");
        foreach (var curso in Cursos)
        {
            Console.WriteLine(curso);
        }
        Console.WriteLine($"Antigüedad: {CalcularAntiguedad()} años");
        ObtenerSalario();
    }

    public int CalcularAntiguedad()
    {
        int aniosContratacion = DateTime.Today.Year - FechaContratacion.Year;
        if (DateTime.Today.Month < FechaContratacion.Month || (DateTime.Today.Month == FechaContratacion.Month && DateTime.Today.Day < FechaContratacion.Day))
        {
            aniosContratacion--;
        }
        return aniosContratacion;
    }

    public double ObtenerSalario()
    {
        return Salario;
    }

    public string MiNumeroDocumentoP()
    {
        return NumeroDocumento;
    }

    public void MiSalario(double valor)
    {
        Salario = valor;
    }

    public string Nombre
    {
        get => base.Nombre;
        set => base.Nombre = value;
    }


}


