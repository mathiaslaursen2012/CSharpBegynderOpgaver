//Opgradér spillet fra Opgave_3 med et Loop sådan at man får flere forsøg når man gætter forkert




//Eksempel på while loop

//While loop der tæller til 10
int counter = 0;
while(counter <= 4)
{
	Console.WriteLine(counter);
	counter++;
}

Console.ReadKey();
//Console.WriteLine("");

//Eksempel på for loop
//for(int i = 0; i < 10; i += 2)
//{
//	Console.WriteLine(i);
//}




Random random = new Random();
int Resultat = random.Next(0, 6);
Console.WriteLine(Resultat);
int antalGæt = 3;

while (counter <= 3)
{
    Console.WriteLine("input a number between 0 & 5");
    int input = Convert.ToInt32(Console.ReadLine());

    if (input == Resultat)
    {
        Console.WriteLine("huray");
        break;

    }

    else
     {
        Console.WriteLine("false");
     }
}






Console.ReadKey();