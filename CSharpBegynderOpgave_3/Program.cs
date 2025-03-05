//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.
Random random = new Random();
int Resultat =  random.Next(0, 6);
Console.WriteLine(Resultat);

Console.WriteLine("input a number between 0 & 5");
int input = Convert.ToInt32(Console.ReadLine());


if(input == Resultat)
{
	Console.WriteLine("huray");
}

else
{
	Console.WriteLine("false");
}




Console.ReadKey();