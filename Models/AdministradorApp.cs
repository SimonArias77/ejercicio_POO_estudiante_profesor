using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ejercicio_POO_profesor_estudiante.Models;

public class AdministradorApp
{
    // creamos las propiedades de la clase

    //creamos la lista de estudiantes
    public static List<Estudiante> Estudiantes = new List<Estudiante>
    {
        // agregamos 5 elementos a la lista de estudiantes
        {
        new Estudiante("Juan", "Perez", "TI", "1534864", "juan23@gmail.com", "3002213964", "Jorge Perez", "septimo", new DateOnly(2008, 10, 20), "carrera 95 #23-10" , new List<double> { 9.5, 9.0, 8.7, 9.2, 9.8 })
        },
        {
        new Estudiante("Maria", "Garcia", "TI", "1234567", "maria3@gmail.com", "3012345678", "Hernan Garcia", "octavo", new DateOnly(2007, 05, 15), "carrera 78 #34-15", new List<double> { 8.3, 9.4, 9.5, 9.6, 9.2 })
        },
        {
        new Estudiante("Pedro", "Lopez", "TI", "7894561", "pedro2@gmail.com", "3098765432", "Pedro Lopez", "noveno", new DateOnly(2006, 02, 10), "carrera 56 #45-10", new List<double> { 7.3, 6.4, 9.5, 8.6, 8.2 })
        },
        {
        new Estudiante("Ana", "Martinez", "TI", "9876543", "ana23@gmail.com", "3034567890", "Luis Martinez", "decimo", new DateOnly(2005, 07, 15), "carrera 34 #56-10", new List<double> { 8.6, 7.9, 8.8, 9.7, 6.4 })
        },
        {
        new Estudiante("Camilo", "Ruiz", "TI", "98763543", "cami56@gmail.com", "3034567220", "Dario Ruiz", "decimo", new DateOnly(2004, 08, 11), "carrera 47 #46-10", new List<double> { 9.2, 6.7, 7.9, 8.4, 8.7 })

        }


    };

    // creamos la lista de profesores
    public static List<Profesor> Profesores = new List<Profesor>
    {
        // agregamos 3 elementos a la lista de profesores
        {
        new Profesor("Juan", "Perez", "CC", "1234567", "juan23@gmail.com", "3002213964", "Matematicas", 30000, new DateTime(2021, 01, 01), new List<string> { "Matemáticas", "Física" })
        },
        {
        new Profesor("Maria", "Garcia", "TI", "7894561", "maria3@gmail.com", "3012345678", "Ingles", 40000, new DateTime(2020, 06, 01), new List<string> { "Química", "Biología" })

        },
        {
        new Profesor("Pedro", "Lopez", "CC", "9876543", "pedro2@gmail.com", "3098765432", "Ciencias Naturales", 25000, new DateTime(2019, 12, 01), new List<string> { "Historia", "Lenguaje" })

        }

    };

    // // creamos el constructor
    // public AdministradorApp(List<Estudiante> estudiantes, List<Profesor> profesores)
    // {
    //     Estudiantes = estudiantes;

    //     Profesores = profesores;
    // }

    // creamos los métodos de la clase

    public void MostrarEstudiantes()
    {
        foreach (var estudiante in Estudiantes)
        {
            estudiante.MostrarDetalles();
        }
    }

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

    public void EditarEstudiante()
    {
        Console.WriteLine("Por favor ingrese el número de documento del estudiante que desea editar");
        string numeroDocumento = Console.ReadLine();
        {
            Estudiante estudianteEncontrado = Estudiantes.Find(x => x.MiNumeroDocumento() == numeroDocumento);
            if (estudianteEncontrado != null)
            {
                Console.WriteLine("Por favor ingrese los nuevos datos del estudiante");
                Console.Write("Nombre: ");
                estudianteEncontrado.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                estudianteEncontrado.Apellido = Console.ReadLine();
                Console.Write("Tipo de documento: ");
                estudianteEncontrado.TipoDocumento = Console.ReadLine();
                Console.Write("Número de documento: ");
                estudianteEncontrado.NumeroDocumento = Console.ReadLine();
                Console.Write("Email:");
                estudianteEncontrado.Email = Console.ReadLine();
                Console.Write("Teléfono: ");
                estudianteEncontrado.Telefono = Console.ReadLine();
                Console.Write("Nombre del acudiente: ");
                estudianteEncontrado.NombreAcudiente = Console.ReadLine();
                Console.Write("Curso actual: ");
                estudianteEncontrado.CursoActual = Console.ReadLine();
                Console.Write("Fecha de nacimiento (dd/MM/yyyy): ");
                string fechaNacimientoString = Console.ReadLine();
                DateOnly fechaNacimiento;

                // Intentar parsear la fecha
                if (DateOnly.TryParseExact(fechaNacimientoString, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
                {
                    estudianteEncontrado.FechaNacimiento = fechaNacimiento;
                    Console.WriteLine("Estudiante editado correctamente");
                }
                else
                {
                    Console.WriteLine("Formato de fecha inválido. Por favor, use el formato dd/MM/yyyy.");
                }
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
    }

    public void EliminarEstudiante()
    {
        Console.WriteLine("Por favor ingrese el número de documento del estudiante que desea eliminar:");
        string numeroDocumentoString = Console.ReadLine();

        // Intentar convertir el número de documento a cadena, no a int
        Estudiante estudianteEncontrado = Estudiantes.Find(x => x.NumeroDocumento == numeroDocumentoString);

        if (estudianteEncontrado != null)
        {
            Estudiantes.Remove(estudianteEncontrado);
            Console.WriteLine("Estudiante eliminado correctamente");
        }
        else
        {
            Console.WriteLine("Estudiante no encontrado.");
        }
    }

    public void MostrarProfesores()
    {
        foreach (var profesor in Profesores)
        {
            profesor.MostrarDetalles();
        }
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

    public void EditarProfesor()
    {
        Console.WriteLine("Por favor ingrese el número de documento del profesor que desea editar:");
        string numeroDocumento = Console.ReadLine();

        // Buscar el profesor por número de documento
        Profesor profesorEncontrado = Profesores.Find(x => x.MiNumeroDocumentoP() == numeroDocumento);

        if (profesorEncontrado != null)
        {
            Console.WriteLine("Por favor ingrese los nuevos datos del profesor:");

            Console.Write("Asignatura: ");
            profesorEncontrado.Asignatura = Console.ReadLine();

            Console.Write("Salario: ");
            // Asegúrate de manejar posibles errores de conversión
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                profesorEncontrado.MiSalario(salario);
            }
            else
            {
                Console.WriteLine("Formato de salario inválido.");
                return; // Salir del método si la conversión falla
            }

            Console.Write("Fecha de contratación (dd/MM/yyyy): ");
            string fechaContratacionString = Console.ReadLine();
            DateTime fechaContratacion;

            // Intentar parsear la fecha
            if (DateTime.TryParseExact(fechaContratacionString, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fechaContratacion))
            {
                profesorEncontrado.FechaContratacion = fechaContratacion;
                Console.WriteLine("Profesor editado correctamente.");
            }
            else
            {
                Console.WriteLine("Formato de fecha inválido. Por favor, use el formato dd/MM/yyyy.");
            }
        }
        else
        {
            Console.WriteLine("Profesor no encontrado.");
        }
    }

    public void EliminarProfesor()
    {
        Console.WriteLine("Por favor ingrese el número de documento del profesor que desea eliminar:");
        string numeroDocumento = Console.ReadLine();

        // Buscar el profesor por número de documento
        Profesor profesorEncontrado = Profesores.Find(x => x.MiNumeroDocumentoP() == numeroDocumento);

        if (profesorEncontrado != null)
        {
            Profesores.Remove(profesorEncontrado);
            Console.WriteLine("Profesor eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Profesor no encontrado.");
        }
    }


    // EJERCICIOS PROPUESTOS UTILIZANDO LINQ:

    // 1. De la lista de estudiantes y encontrar aquellos con un promedio de calificaciones superior
    // a 85.
    public void ObtenerEstudiantesConPromedioAlto()
    {
        var estudiantesConPromedioAlto = Estudiantes
            .Where(e => e.Calificaciones.Average() > 85)
            .ToList();

        foreach (var estudiante in estudiantesConPromedioAlto)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Promedio: {estudiante.Calificaciones.Average()}");
        }
    }

    // 2. Obtener la lista de profesores que enseñan más de un curso.
    public void ObtenerProfesoresConMasDeUnCurso()
    {
        var profesoresMulticurso = Profesores
            .Where(p => p.Cursos.Count > 1)
            .ToList();

        foreach (var profesor in profesoresMulticurso)
        {
            Console.WriteLine($"Nombre: {profesor.Nombre}, Cursos: {string.Join(", ", profesor.Cursos)}");
        }
    }

    // 3. Filtrar la lista de estudiantes para obtener solo aquellos cuya edad sea mayor a 16 años.
    public void ObtenerEstudiantesMayoresDe16()
    {
        var estudiantesMayoresDe16 = Estudiantes
            .Where(e => DateTime.Now.Year - e.FechaNacimiento.Year > 16)
            .ToList();

        foreach (var estudiante in estudiantesMayoresDe16)
        {
            int edad = DateTime.Now.Year - estudiante.FechaNacimiento.Year;
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {edad}");
        }
    }

    // 4. Obtener la lista de estudiantes ordenada por apellido en orden ascendente.
    public void ObtenerEstudiantesOrdenadosPorApellido()
    {
        var estudiantesOrdenadosPorApellido = Estudiantes
            .OrderBy(e => e.Apellido)
            .ToList();

        foreach (var estudiante in estudiantesOrdenadosPorApellido)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Apellido: {estudiante.Apellido}");
        }
    }
    // 5. Calcular el salario total de todos los profesores.
    public void CalcularSalarioTotalProfesores()
    {
        double salarioTotal = Profesores
            .Sum(p => p.ObtenerSalario());

        Console.WriteLine($"Salario total de todos los profesores: {salarioTotal}");
    }

    // 6. Encontrar el estudiante con la calificación más alta en su curso actual.
    public void ObtenerEstudianteConCalificacionMasAlta()
    {
        var estudianteConCalificacionMasAlta = Estudiantes
            .OrderByDescending(e => e.Calificaciones.Max())
            .FirstOrDefault();

        if (estudianteConCalificacionMasAlta != null)
        {
            Console.WriteLine($"Nombre: {estudianteConCalificacionMasAlta.Nombre}, Calificación más alta: {estudianteConCalificacionMasAlta.Calificaciones.Max()}");
        }
        else
        {
            Console.WriteLine("No se encontraron estudiantes.");
        }
    }

    // 7. Determinar el número de estudiantes en cada curso.
    public void ObtenerNumeroDeEstudiantesPorCurso()
    {
        var estudiantesPorCurso = Estudiantes
            .GroupBy(e => e.CursoActual)
            .Select(g => new { Curso = g.Key, NumeroEstudiantes = g.Count() })
            .ToList();

        foreach (var curso in estudiantesPorCurso)
        {
            Console.WriteLine($"Curso: {curso.Curso}, Número de estudiantes: {curso.NumeroEstudiantes}");
        }
    }

    // 8. Filtrar los profesores que tienen más de 10 años de antigüedad en la institución.
    public void ObtenerProfesoresConMasDe10Anios()
    {
        var profesoresAntiguos = Profesores
            .Where(p => DateTime.Now.Year - p.FechaContratacion.Year > 10)
            .ToList();

        foreach (var profesor in profesoresAntiguos)
        {
            // Utiliza 'profesor' en lugar de 'p'
            Console.WriteLine($"Nombre: {profesor.Nombre}, Años de antigüedad: {DateTime.Now.Year - profesor.FechaContratacion.Year}");
        }
    }

    // 9. Obtener la lista de asignaturas únicas que se imparten en la escuela.
    public void ObtenerAsignaturasUnicas()
    {
        var asignaturasUnicas = Profesores
            .SelectMany(p => p.Cursos)
            .Distinct()
            .ToList();

        Console.WriteLine("Asignaturas únicas en la escuela:");
        foreach (var asignatura in asignaturasUnicas)
        {
            Console.WriteLine(asignatura);
        }
    }

    // 10. Encontrar todos los estudiantes cuyo nombre de acudiente sea 'María'.
    public void ObtenerEstudiantesConAcudienteMaria()
    {
        var estudiantesConAcudienteMaria = Estudiantes
            .Where(e => e.NombreAcudiente.Equals("Maria", StringComparison.OrdinalIgnoreCase))
            .ToList();

        foreach (var estudiante in estudiantesConAcudienteMaria)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Acudiente: {estudiante.NombreAcudiente}");
        }
    }

    // 11. Ordenar la lista de profesores por salario en orden descendente.
    public void ObtenerProfesoresOrdenadosPorSalario()
    {
        var profesoresOrdenadosPorSalario = Profesores
            .OrderByDescending(p => p.ObtenerSalario())
            .ToList();

        foreach (var profesor in profesoresOrdenadosPorSalario)
        {
            Console.WriteLine($"Nombre: {profesor.Nombre}, Salario: {profesor.ObtenerSalario()}");
        }
    }

    // 12. Calcular el promedio de edad de los estudiantes.

    public void CalcularPromedioEdadEstudiantes()
    {
        double promedioEdad = Estudiantes
            .Average(e => DateTime.Now.Year - e.FechaNacimiento.Year);

        Console.WriteLine($"Promedio de edad de los estudiantes: {promedioEdad}");
    }

    // 13. Encontrar los profesores que enseñan 'Matemáticas'.
    public void ObtenerProfesoresQueEnsenanMatematicas()
    {
        var profesoresMatematicas = Profesores
            .Where(p => p.Cursos.Contains("Matemáticas"))
            .ToList();

        foreach (var profesor in profesoresMatematicas)
        {
            Console.WriteLine($"Nombre: {profesor.Nombre}, Asignatura: {profesor.Asignatura}");
        }
    }

    // 14. Obtener la lista de estudiantes que tienen más de tres calificaciones registradas.
    public void ObtenerEstudiantesConMasDeTresCalificaciones()
    {
        var estudiantesConMasDeTresCalificaciones = Estudiantes
            .Where(e => e.Calificaciones.Count > 3)
            .ToList();

        foreach (var estudiante in estudiantesConMasDeTresCalificaciones)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Número de calificaciones: {estudiante.Calificaciones.Count}");
        }
    }

    // 15. Calcular la antigüedad promedio de todos los profesores.
    public void CalcularAntiguedadPromedioProfesores()
    {
        double antiguedadPromedio = Profesores
            .Average(p => DateTime.Now.Year - p.FechaContratacion.Year);

        Console.WriteLine($"Antigüedad promedio de los profesores: {antiguedadPromedio} años");
    }
}


