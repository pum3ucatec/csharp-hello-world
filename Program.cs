using System;

public class Program {
    static void Main(string[] args) {
        Persona p1 = new Persona();
        Persona p2 = new Persona("Gaston", 44);
        Persona p3 = new Persona("Genaro", 80);

        p1.MostrarInformacion();
        p2.MostrarInformacion();
        p3.MostrarInformacion();

        Console.ReadLine();
    }
}
