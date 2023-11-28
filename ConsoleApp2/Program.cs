bool numUniInfalide = false;

do
{
    Console.WriteLine("donne moi un chiffre entre 10 et 20.");
    string numUti = Console.ReadLine();
    int num = int.Parse(numUti);
    Console.Clear();
    numUniInfalide = num < 10 || num > 20;
    if (num > 20)
    {
        Console.WriteLine("tes con ?");
        Console.WriteLine();
        Console.WriteLine("plus petit !!");

    }
    else if (num < 10)
    {
        Console.WriteLine(" -_-' ");
        Console.WriteLine();
        Console.WriteLine("aller fait pas le con donne moi en un plus grand, tu veux que je fasse quoi avec sa ?");
    }
}



while (numUniInfalide);
    Console.WriteLine("al hamdulilah, les deux neuronnes sont conaicter");

//coriger//

