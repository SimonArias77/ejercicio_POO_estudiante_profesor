using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_POO_profesor_estudiante.Models;

public class Persona
{
    // creamos las propiedades de la clase

    protected Guid Id { get; set; }
    protected string Nombre { get; set; }
    protected string Apellido { get; set; }
    protected string TipoDocumento { get; set; }
    protected string NumeroDocumento { get; set; }
    protected string Email { get; set; }
    protected string Telefono { get; set; }

    // creamos el constructor
    public Persona(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono)
    {
        Id = new Guid();
        Nombre = nombre;
        Apellido = apellido;
        TipoDocumento = tipoDocumento;
        NumeroDocumento = numeroDocumento;
        Email = email;
        Telefono = telefono;
    }
    protected Persona()
    {
        Id = Guid.NewGuid();
    }


    // creamos los métodos de la clase

    public void MostrarDetalles()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre} {Apellido}");
        Console.WriteLine($"Tipo de documento: {TipoDocumento}");
        Console.WriteLine($"Número de documento: {NumeroDocumento}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }
}
