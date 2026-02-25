
Console.WriteLine("Hospital");


public class Hospitales
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public DateTime Fecha_Inaguracion { get; set; }
    public bool Activo { get; set; }


    public List<Sedes>? Sedes { get; set; }
    public List<Servicios>? Servicios { get; set; }
    public List<Zonas_Comunes>? Zonas_Comunes { get; set; }
    public List<Parqueaderos>? Parqueaderos { get; set; }
    public List<Ingresos>? Ingresos { get; set; }
    public List<Pacientes>? Pacientes { get; set; }
    public List<Empleados>? Empleados { get; set; }

}

public class Sedes
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public bool Activo { get; set; }


    public int Hospital { get; set; }
    public Hospitales? _Hospital { get; set; }
}

public class Servicios
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public string? Especialidad { get; set; }
    public int Capacidad { get; set; }
    public bool Activo { get; set; }

    public Hospitales? _Hospital { get; set; }
}

    public class Zonas_Comunes
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public string? Tipo { get; set; }
    public bool Activo { get; set; }

    public Hospitales? _Hospital { get; set; }
}


public class Parqueaderos
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Tipo { get; set; }
    public bool Ocupado { get; set; }

    public int Hospital { get; set; }
    public Hospitales? _Hospital { get; set; }
}

public class Personas
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha_Nacimiento { get; set; }
    public bool Activo { get; set; }
}

public class Ingresos : Personas
{
    public string? Codigo { get; set; }
    public string? Motivo_Consulta { get; set; }
    public string? Diagnostico { get; set; }
    public DateTime Ingreso_Urgencias { get; set; }

    public int Hospital { get; set; }
    public Hospitales? _Hospital { get; set; }
}

public interface Orden
{
    string Orden();
}

public class Pacientes : Personas, Orden
{
    public string? Cuidados { get; set; }
    public string? Medicamentos { get; set; }
    public DateTime Ingreso_Hospitalizacion { get; set; }
    public string Orden()
    {
        return "Motivo Hospitalizacion: " + Orden;
    }

    public int Hospital { get; set; }
    public Hospitales? _Hospital { get; set; }
}

public class Empleados : Personas
{
    public string? Nombre_Cargo { get; set; }
    public decimal Salario { get; set; }
    public int Hospital { get; set; }
    public Hospitales? _Hospital { get; set; }
}

    

   
    
