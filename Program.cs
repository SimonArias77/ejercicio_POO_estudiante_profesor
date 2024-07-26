// enlazamos las clases creadas con program por medio  del "using"
using ejercicio_POO_profesor_estudiante.Models;

// creamos una lista de 5 estudiantes con la siguiente información: nombre, apellido, tipo de documento, número de documento, email, teléfono, nombre del acudiente, curso actual, fecha de nacimiento, dirección y calificaciones
var estudiantes = new List<Estudiante>();

// agregamos 5 elementos a la lista de estudiantes
estudiantes.Add(new Estudiante("Juan", "Perez", "TI", "1534864", "juan23@gmail.com", "3002213964", "Jorge Perez", "septimo", new DateOnly (2008, 10, 20), "carrera 95 #23-10" , new List<double> { 9.5, 9.0, 8.7, 9.2, 9.8 }));
estudiantes.Add(new Estudiante("Maria", "Garcia", "TI", "1234567", "maria3@gmail.com", "3012345678", "Hernan Garcia", "octavo", new DateOnly (2007, 05, 15), "carrera 78 #34-15" , new List<double> { 8.3, 9.4, 9.5, 9.6, 9.2}));
estudiantes.Add(new Estudiante("Pedro", "Lopez", "TI", "7894561", "pedro2@gmail.com", "3098765432", "Pedro Lopez", "noveno", new DateOnly (2006, 02, 10), "carrera 56 #45-10" , new List<double> { 7.3, 6.4, 9.5, 8.6, 8.2}));
estudiantes.Add(new Estudiante("Ana", "Martinez", "TI", "9876543", "ana23@gmail.com", "3034567890", "Luis Martinez", "decimo", new DateOnly (2005, 07, 15), "carrera 34 #56-10" , new List<double> { 8.6, 7.9, 8.8, 9.7, 6.4}));
estudiantes.Add(new Estudiante("Camilo", "Ruiz", "TI", "98763543", "cami56@gmail.com", "3034567220", "Dario Ruiz", "decimo", new DateOnly (2004, 08, 11), "carrera 47 #46-10" , new List<double> { 9.2, 6.7, 7.9, 8.4, 8.7}));
// mostramos los detalles de cada estudiante
Console.WriteLine(estudiantes.Count);
Console.WriteLine("los detalles de cada estudiante son los siguientes:");
foreach (var estudiante in estudiantes)
{
    estudiante.MostrarDetalles();
}

// creamos una lista  3 de profesores con la siguiente información: nombre, apellido, tipo de documento, número de documento, email, teléfono, asignatura, salario, fecha de contratación, y cursos asignados.
var profesores = new List<Profesor>();

// agregamos 3 elementos a la lista de profesores
profesores.Add(new Profesor("Juan", "Perez", "CC", "1234567", "juan23@gmail.com", "3002213964", "Matematicas", 30000, new DateTime(2021, 01, 01), new List<string> {"Matemáticas", "Física"}));
profesores.Add(new Profesor("Maria", "Garcia", "TI", "7894561", "maria3@gmail.com", "3012345678", "Ingles", 40000, new DateTime(2020, 06, 01), new List<string> {"Química", "Biología"}));
profesores.Add(new Profesor("Pedro", "Lopez", "CC", "9876543", "pedro2@gmail.com", "3098765432", "Ciencias Naturales", 25000, new DateTime(2019, 12, 01), new List<string> {"Historia", "Lenguaje"}));

// mostramos los detalles de cada profesor
Console.WriteLine(profesores.Count);
Console.WriteLine("los detalles de cada profesor son los siguientes:");
foreach (var profesor in profesores)
{
    profesor.MostrarDetallesP();
}