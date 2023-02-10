Console.WriteLine("Ingrese la primera cadena: ");
string cadena1 = Console.ReadLine();
Console.WriteLine("Ingrese la segunda cadena: ");
string cadena2 = Console.ReadLine();

if (string.Compare(cadena1, cadena2) < 0)
{
    Console.WriteLine("Cadenas en orden alfabético: \n" + cadena1 + "\n " + cadena2);
}
else
{
    Console.WriteLine("Cadenas en orden alfabético: \n" + cadena2 + " \n" + cadena1);
}