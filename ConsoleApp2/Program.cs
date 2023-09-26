Console.WriteLine("donner numero");

string saissie = Console.ReadLine();
int nombre = int.Parse(saissie);
int result = nombre * nombre;

Console.WriteLine($"le carré de {nombre} est {result}");

