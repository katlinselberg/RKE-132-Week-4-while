
Random rnd = new Random();
int cpuRandom;

bool loopactive = true; //bool - true/false
while (loopactive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //Loopactive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops. Try again!");
    }
}
Console.WriteLine("Have a nice day!");
