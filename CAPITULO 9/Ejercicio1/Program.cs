

Producto producto1;
producto1.Nombre = "Salami";
producto1.Precio = 10.5;
producto1.Cantidad = 20;

Producto producto2;
producto2.Nombre = "Queso";
producto2.Precio = 15.75;
producto2.Cantidad = 25;

Console.WriteLine("Nombre: " + producto1.Nombre + ", Precio: " + producto1.Precio + ", Cantidad: " + producto1.Cantidad);
Console.WriteLine("Nombre: " + producto2.Nombre + ", Precio: " + producto2.Precio + ", Cantidad: " + producto2.Cantidad);


struct Producto
    {
        public string Nombre;
        public double Precio;
        public int Cantidad;
    }