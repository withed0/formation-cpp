using System.Net.Http.Headers;
using System.Runtime.Serialization;

Console.Write("quelle est votre âge ?");
string ageUti = Console.ReadLine();
int age = int.Parse(ageUti);

Console.Clear();
Console.Write("êtes vous une femme ou un homme ?");
Console.WriteLine();
Console.WriteLine("1.femme");
Console.WriteLine("2.homme");
Console.WriteLine();
Console.Write("choissisez 1 ou 2 : ");
string genreUti = Console.ReadLine();
int choixgenre = int.Parse(genreUti);

string messagefinal = "tu est";

if (choixgenre == 1 && age < 18)
{
    messagefinal += " mineure.";
}
else if (choixgenre == 2 && age >= 18)
{
    messagefinal += " majeure.";
}
else if (choixgenre == 2 &&  age < 18)
{
    messagefinal +=" mineur.";
}
else if (choixgenre == 2 && age >= 18)
{
    messagefinal += " majeur.";
}
else if (choixgenre == 1 && age >= 150choixgenre == 2);
else 
{
    Console.Clear();
    Console.WriteLine();
}
Console.WriteLine(messagefinal);