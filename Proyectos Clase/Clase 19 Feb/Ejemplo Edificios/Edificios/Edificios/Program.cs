using System.Collections;

Console.WriteLine("EDIFICIOS");

//Ejemplo llenar un Lista de Zonaz Comunes vehiculo.tipos = new List<Tipos>();
//vehiculo.tipos.Add(new Tipos() { id = 1, nombre = "HIBRIDO" });

Personas persona = new Personas()
{
    Id = 1,
    Cedula = "123",
    Nombre = "Pepito",
    Fecha_Expedicion = DateTime.Now,
    Activo = true,
};
Personas dueño = new Dueños()
{
    Id = 1,
    Cedula = "123",
    Nombre = "Pepito",
    Fecha_Expedicion = DateTime.Now,
    Activo = true,
};
Dueños dueño1 = (Dueños)dueño;
INacionalidad dueño2 = (INacionalidad)dueño;



public class Edificios
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public DateTime Fecha_Inauguracion { get; set; }
    public bool Activo { get; set; }

    public List<Apartamentos>? Apartamentos { get; set; } //Un EDIFCIO tiene muchos Apartamentos
                                                          //Es una lista que Contiene objetos del tipo Apartamentos, Es decir:
                                                          //Un edificio puede tener varios apartamentos.
                                                          //Relación uno a muchos (1:N)
    public List<Parqueaderos>? Parqueaderos { get; set; } // Un EDIFICIO tiene muchos Parqueaderos
                                                          //Es una lista que Contiene objetos del tipo Parqueaderos, Es decir:
                                                          //Un edificio puede tener varios Parqueaderos.
                                                          //Relación uno a muchos (1:N)
    public List<Empleados>? Empleados { get; set; } //Un EDIFICIO Tiene mucho Empleados
                                                    //Es una lista que Contiene objetos del tipo Empleados, Es decir:
                                                    //Un edificio puede tener varios Empleados.
                                                    //Relación uno a muchos (1:N)

    public List<Zonas_Comunes>? Zonas_Comunes { get; set; } //Un EDIFICIO Tiene muchas Zonas Comunes
                                                            //Es una lista que Contiene objetos del tipo Zonas Comunes, Es decir:
                                                            //Un edificio puede tener varias Zonas Comunes.
                                                            //Relación uno a muchos (1:N)


}

public class Zonas_Comunes
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Lugar { get; set; }
    public string? Tipo { get; set; }
    public bool Activo { get; set; }

    public int Edificio { get; set; } // Guarda un número entero que representa el ID del edificio. Normalmente se usa como: Clave foránea en base de datos o
                                      // Identificador del edificio al que pertenece la zona comun
    public Edificios? _Edificios { get; set; } //Es otro tipo de clase, Significa que una Zona Comun tiene una relación con un objeto Edificios
                                               // El ? significa que puede ser Null o puede no tenerlo
                                               //Esto normalmente se usa en Entity Framework (relaciones en base de datos).
                                               //Edificio Es la clave foránea (Foreign Key) & _Edificio Es la propiedad de navegación (Navigation Property).

}

public class Apartamentos //Apartamentos Tiene Duenos y pertenecen a un Edificio en concreto.
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public int Habitaciones { get; set; }
    public decimal Area { get; set; }
    public bool Activo { get; set; }

    public int Edificio { get; set; } // Guarda un número entero que representa el ID del edificio. Normalmente se usa como: Clave foránea en base de datos o
                                      // Identificador del edificio donde trabaja el empleado

    public int Dueños { get; set; } // Guarda un número entero que representa el ID del Dueño. Normalmente se usa como: Clave foránea en base de datos o
                                    // Identificador del Dueño del Apartamento

    public Edificios? _Edificio { get; set; } //Es otro tipo de clase, Significa que un Apartamento tiene una relación con un objeto Edificios
                                              // El ? significa que puede ser Null o puede no tenerlo
                                              //Esto normalmente se usa en Entity Framework (relaciones en base de datos).
                                              //Edificio Es la clave foránea (Foreign Key) & _Edificio Es la propiedad de navegación (Navigation Property).
    public Dueños? _Dueño { get; set; } //Es otro tipo de clase, Significa que un Apartamento tiene una relación con un objeto Dueños
                                        // El ? significa que puede ser Null o puede no tenerlo
                                        //Esto normalmente se usa en Entity Framework (relaciones en base de datos).
                                        //Dueños Es la clave foránea (Foreign Key) & _Dueños Es la propiedad de navegación (Navigation Property).

}

public class Parqueaderos
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Tipo { get; set; }
    public bool Ocupado { get; set; }

    public int Edificio { get; set; } // Guarda un número entero que representa el ID del edificio. Normalmente se usa como: Clave foránea en base de datos o
                                      // Identificador del edificio donde trabaja el empleado

    public Edificios? _Edificio { get; set; } //Es otro tipo de clase, Significa que un Apartamento tiene una relación con un objeto Edificios
                                              // El ? significa que puede ser Null o puede no tenerlo
                                              //Esto normalmente se usa en Entity Framework (relaciones en base de datos).
                                              //Edificio Es la clave foránea (Foreign Key) & _Edificio Es la propiedad de navegación (Navigation Property).

}

public class Personas
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha_Expedicion { get; set; }
    public bool Activo { get; set; }
}

public class Empleados : Personas
{
    public int Edificio { get; set; }
    
    public Edificios? _Edificios { get; set; }
}

public interface INacionalidad //Herencia Multiple: C# no admite, pero admite que se cumpla la mimas funcionalidad con interfases.
{
    string DeDondeEs(); //Definimos un Metodo que permita heredar los atributos y/o funciones de las clases hijas. 
}

public class Dueños : Personas, INacionalidad //Como vemos, la clase hija "Duenos" hereda de Personas & Nacionalidad por lo tanto es una herencia multiple
{
    public string DeDondeEs() //Debemos llamar el metodo que definimos como interface y dandole a retornar el value (dependiendo el tipo de dato)
                              //con el fin de que herede lo que se necesita en esta herencia
    {
        return "Colombia";
    }
}