while (true)
{


    Console.WriteLine("Enter an integer: ");
    string answer = Console.ReadLine();


    int aNumber = Convert.ToInt32(answer);

    if (aNumber == 0)
    {
        break;

    }

    if (aNumber % 2 == 0)
    {

        Console.WriteLine($"{aNumber} is even.");
    }
    else
    {
        Console.WriteLine($"{aNumber} is even.");

    }
}



Console.WriteLine("Done...");


