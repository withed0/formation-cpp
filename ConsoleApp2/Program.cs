Console.WriteLine("donner moi deux nombre");
string numUti = Console.ReadLine();
int num = int.Parse(numUti);
string numUti2 = Console.ReadLine();
int num2 = int.Parse(numUti2);
if (0<num && num2>0)
{
    Console.WriteLine("le produit est posotif")
}
else if (0>num && num2<0)
{
    Console.WriteLine("le produit est negatif")
}
else (0>num && num2>0 || 0<num && num2>0)
{
    Console.WriteLine("le produit est negatif")
}