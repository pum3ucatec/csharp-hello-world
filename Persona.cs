using System;

public class Persona {
    // Propiedades de la clase
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor
    public Persona() {
        this.Nombre = "N/A";
        this.Edad = 0;
    }

    public Persona(string nombre, int edad) {
        this.Nombre = nombre;
        this.Edad = edad;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {this.Nombre}, Edad: {this.Edad}");
    }
}
