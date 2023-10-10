Console.WriteLine("donner moi deux nombre");
string numUti = Console.ReadLine();
int num = int.Parse(numUti);
string numUti2 = Console.ReadLine();
int num2 = int.Parse(numUti2);
if (0<num && 0<num2)
{
    Console.WriteLine("le produit est positif");
}
else if (0>num && 0>num2)
{
    Console.WriteLine("le nombre est negatif");
}
else
{
    Console.WriteLine("le nombre est negatif");
}