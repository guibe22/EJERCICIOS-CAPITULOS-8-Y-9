Dueño dueño1;
dueño1.Nombre = "Juan";
dueño1.Edad = 30;

Dueño dueño2;
dueño2.Nombre = "Maria";
dueño2.Edad = 25;

Mascota mascota1;
mascota1.Nombre = "Fido";
mascota1.Tipo = "Perro";
mascota1.Propietario = dueño1;

Mascota mascota2;
mascota2.Nombre = "Mimi";
mascota2.Tipo = "Gato";
mascota2.Propietario = dueño2;

Console.WriteLine("Nombre mascota: " + mascota1.Nombre + ", Tipo: " 
+ mascota1.Tipo + ", Nombre dueño: " + mascota1.Propietario.Nombre 
+ ", Edad: " + mascota1.Propietario.Edad);

Console.WriteLine("Nombre mascota: " + mascota2.Nombre + 
", Tipo: " + mascota2.Tipo + ", Nombre dueño: " +
 mascota2.Propietario.Nombre + ", Edad: " + mascota2.Propietario.Edad);


struct Dueño
    {
        public string Nombre;
        public int Edad;
    }

    struct Mascota
    {
        public string Nombre;
        public string Tipo;
        public Dueño Propietario;
    }