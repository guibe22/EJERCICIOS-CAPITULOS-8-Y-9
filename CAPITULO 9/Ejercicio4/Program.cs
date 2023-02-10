TipoNeumatico neumatico1 = TipoNeumatico.Verano;
TipoNeumatico neumatico2 = TipoNeumatico.Invierno;
TipoNeumatico neumatico3 = TipoNeumatico.TodoTerreno;
TipoNeumatico neumatico4 = TipoNeumatico.Performance;

Console.WriteLine("Tipo de neumatico 1: " + (int)neumatico1 + " - " + neumatico1);
Console.WriteLine("Tipo de neumatico 2: " + (int)neumatico2 + " - " + neumatico2);
Console.WriteLine("Tipo de neumatico 3: " + (int)neumatico3 + " - " + neumatico3);
Console.WriteLine("Tipo de neumatico 4: " + (int)neumatico4 + " - " + neumatico4);


enum TipoNeumatico
{
    Verano = 1,
    Invierno = 2,
    TodoTerreno = 3,
    Performance = 4
}