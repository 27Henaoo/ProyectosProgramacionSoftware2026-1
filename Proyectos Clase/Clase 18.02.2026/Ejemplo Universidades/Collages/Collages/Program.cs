using System.Security.Cryptography.X509Certificates;

Console.WriteLine("CLASE 17/02/2026");


Universidades universidad = new Universidades()
{
    Nombre = "ITM",
    Activa = false,
};

universidad.id = 1;
var temp = universidad.id;

universidad.sedes = new List<Sedes>();

universidad.sedes.Add(new Sedes() { Id = 1, Nombre = "Fraternidad" });
universidad.sedes.Add(new Sedes() { Id = 2, Nombre = "Robledo" });

foreach (var elemento in universidad.sedes)
{
    Console.WriteLine("Id: " + elemento.Id + ", " + "Nombre: " + elemento.Nombre);
}

public class Sedes
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Capacidad { get; set; }
    public int Universidad { get; set; }

    public Universidades _universidad{ get; set;} 
}

public class Universidades
{
    public int Id = 0;
    public string? Nombre = "";
    public DateTime Fecha = DateTime.Now;
    public bool Activa = true;

    public List<Sedes> sedes;

    public Universidades()
    {

    }

    public int id
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    public string? nombre
    {
        get { return this.Nombre; }
    }
}