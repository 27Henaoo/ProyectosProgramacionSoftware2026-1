using System.Runtime.CompilerServices;

Console.WriteLine("DEPORTES");

Deportes deporte = new Deportes()
{
    Id = 1,
    Nombre = "Futbol",
    Deportes_Equipos = new List<Deportes_Equipos>(),
};

Equipos equipo = new Equipos() 
{
    Id = 1,
    Nombre = "Barcelona",
};

Personas entrenador = new Entrenadores()
{
    Id = 1,
    Nombre = "Pablo",
    Equipo = equipo.Id,
    _Equipo = equipo
};

Personas deportista1 = new Deportistas()
{
    Id = 1,
    Nombre = "Juan",
    Sueldo = 20000000.0m,
    Equipo = equipo.Id,
    _Equipo = equipo,
};

Personas deportista2 = new Deportistas()
{
    Id = 2,
    Nombre = "Pablo",
    Sueldo = 40000000.0m,
    Equipo = equipo.Id,
    _Equipo = equipo,

};


public class Deportes
{
    public int Id { get; set; }
    public String? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }

    public List<Deportes_Equipos>? Deportes_Equipos { get; set; }
    public List<Implementos>? Implementos { get; set; }

}

public class Deportes_Equipos
{
    public int Id { get; set; }
    public int Deporte { get; set; }
    public int Equipo { get; set; }

    public Deportes? _Deporte { get; set; }
    public Equipos? _Equipo { get; set; }
    
}

public class Equipos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }

    public List<Deportes_Equipos>? Deportes_Equipos { get; set; }
    public List<Deportistas>? Deportistas { get; set; }
    public List<Entrenadores>? Entrenadores { get; set; }

}

public class Personas
{
    public int Id { get; set; }
    public String? Cedula { get; set; }
    public String? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Actico { get; set; }
}

public class Entrenadores : Personas
{
    public int Equipo { get; set; }

    public Equipos? _Equipo { get; set; }
}

public class Deportistas : Personas
{
    public decimal Sueldo { get; set; }
    public int Equipo { get; set; }

    public Equipos? _Equipo { get; set; }
}

public class Implementos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }
    public int Deporte { get; set; }

    public Deportes? _Deporte { get; set; }
}