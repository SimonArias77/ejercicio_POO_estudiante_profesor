using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_POO_profesor_estudiante.Models;

public class AdministradorApp
{
    // creamos las propiedades de la clase

    public List<Estudiante> Estudiantes { get; set; }
    public List<Profesor> Profesores { get; set; }

    // creamos el constructor
    public AdministradorApp(List<Estudiante> estudiantes, List<Profesor> profesores)
    {
        Estudiantes = estudiantes;
        Profesores = profesores;
    }

    // creamos los métodos de la clase

    public void AgregarEstudiante()
    {
        Console.WriteLine("Por favor ingrese los datos del estudiante");
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        string apellido = Console.ReadLine();
        Console.Write("Tipo de documento: ");
        string tipoDocumento = Console.ReadLine();
        Console.Write("Número de documento: ");
        string numeroDocumento = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine();
        Console.Write("Nombre del acudiente: ");
        string nombreAcudiente = Console.ReadLine();
        Console.Write("Curso actual: ");
        string cursoActual = Console.ReadLine();
        Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
        string fechaNacimientoString = Console.ReadLine();
    }

    public void AgregarProfesor()
    {
        Console.WriteLine("Por favor ingrese los datos del profesor");
        Console.Write("Asignatura: ");
        string asignatura = Console.ReadLine();
        Console.Write("Salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Fecha de contratación (dd/mm/yyyy): ");
        string fechaContratacionString = Console.ReadLine();
        Console.Write("Cursos en los que imparte: ");
        List<string> cursos = Console.ReadLine().Split(',').ToList();
    }

    public void MostrarEstudiantes()
    {
        foreach (var estudiante in Estudiantes)
        {
            estudiante.MostrarDetalles();
        }
    }

    public void MostrarProfesores()
    {
        foreach (var profesor in Profesores)
        {
            profesor.MostrarDetallesP();
        }
    }
}
