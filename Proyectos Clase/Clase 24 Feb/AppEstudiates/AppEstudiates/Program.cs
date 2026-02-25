
Console.WriteLine("App Estudiantes");


public class Grupos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Descuento { get; set; }
    public bool Activo { get; set; }


}

public class Materias
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public bool Activo { get; set; }

}

public class Estudiantes
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Codigo { get; set; }
    public bool Activo { get; set; }

}

public class Notas
{
    public int Id { get; set; }
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }
    public decimal Nota3 { get; set; }
    public decimal Nota4 { get; set; }
    public decimal Nota5 { get; set; }
    public decimal NotaF { get; set; }


}
