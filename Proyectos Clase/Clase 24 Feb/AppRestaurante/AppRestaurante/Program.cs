Console.WriteLine("Bienvenido Al Restaurante");

public class Clientes
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string? Correo { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }

    public List<Ventas>? Ventas { get; set; }
}

public class Productos
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public decimal Cantidad { get; set; }
    public decimal Valor { get; set; }

    public List<Ventas_Productos>? Ventas_Productos { get; set; }
}

public class Ventas
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Total{ get; set; }
    public decimal Descuento { get; set; }

    public int Cliente { get; set; }
    public Clientes? _Cliente { get; set; }

    public List<Ventas_Productos>? Ventas_Productos { get; set; }
}



public class Ventas_Productos
{
    public int Id { get; set; }

    public decimal Cantidad { get; set; }
    public decimal Valor { get; set; }
    public decimal SubTotal{ get; set; }


    public int Producto { get; set; }
    public int Venta { get; set; }

    public Productos? _Producto { get; set; }
    public Ventas? _Venta{ get; set; }
}