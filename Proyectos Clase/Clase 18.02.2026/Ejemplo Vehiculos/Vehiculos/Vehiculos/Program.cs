Console.WriteLine("Clase 18-02-2026");

var vehiculo = new Vehiculos()
{
    Id = 1,
    Placa = "EIO231"
};

vehiculo.Marcas = new Marcas() { Id = 1, Nombre = "Chevrolet" };
vehiculo.Tipos = new List<Tipos>();

// Anadir objetos a la lista 

vehiculo.Tipos.Add(new Tipos() { Id = 1, Nombre = "HIBRIDO" });
vehiculo.Tipos.Add(new Tipos() { Id = 2, Nombre = "ELECTRICO"});
vehiculo.Tipos.Add(new Tipos() { Id = 3, Nombre = "GASOLINA" });

Console.WriteLine ("id: " + vehiculo.Id + ", " +
    "placa: " + vehiculo.Placa + ", " +
    "kilometraje: " + vehiculo.Kilometraje + ", " +
    "modelo: " + vehiculo.Modelo + ", " +
    "activo: " + vehiculo.Activo + ", " +
    "marca: " + vehiculo.Marcas.Nombre);

foreach (var elemento in vehiculo.Tipos)
{
    Console.WriteLine("Id:" + elemento.Id + "," + "Nombre:" + elemento.Nombre);
}

// Polimorfismo
Personas persona = new Personas() { Nombre = "Juan" };
Personas estudiante = new Estudiantes() { Nombre = "Santiago" };
Personas profesor = new Profesores() { Nombre = "Samuel" };

//Clases

public class Marcas
{
    //Atributos y Propiedades

    public int Id { get; set; }
    public string? Nombre { get; set; }

}

public class Tipos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
}

public class Vehiculos
{
    private int id = 0;
    private string? placa = "";
    private decimal kilometraje = 0.0m;
    private DateTime modelo = DateTime.Now;
    private bool activo = true;
    private Marcas? marcas = null;
    private List<Tipos>? tipos = null;

    // Contructor 

    public Vehiculos()
    {

    }

    //Propiedades 
    public int Id { get => id; set => id = value; }
    public string? Placa { get => placa; set => placa = value; }
    public decimal Kilometraje { get => kilometraje; set => kilometraje = value; }
    public DateTime Modelo { get => modelo; set => modelo = value; }
    public bool Activo { get => activo; set => activo = value; }
    public Marcas? Marcas { get => marcas; set => marcas = value; }
    public List<Tipos>? Tipos { get => tipos; set => tipos = value; }

    //Metodos
    public int GetId() { return this.Id; }
}

//Herencia y Polimorfismo

public class Personas
{
    private int Id = 0; //Encapsulado
    protected string? Cedula = ""; //Encapsulado
    public string? Nombre = "";
}

public class Estudiantes : Personas
{
    public void setCedula(String value) { this.Cedula = value; }
    public string? GetCedula() { return this.Cedula; }
}

public class Profesores : Personas
{

}

