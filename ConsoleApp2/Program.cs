Console.WriteLine("donner un nombre");
string numUti = Console.ReadLine();
int num = int.Parse(numUti);
if (num>0)
{
    Console.WriteLine("le nombre est positif");
}
else if (num<0)
{
    Console.WriteLine("le nombre est negatif");
}
else
{
    Console.WriteLine("le nombre est negatif et positif"); 
}