using System;

Random rnd = new Random();

int myRandomNum = rnd.Next(0, 11); // 0-10

int randomsum = 0;

for (int i = 0; i < 10; i++) 
{
    Console.WriteLine($"My random number is: {myRandomNum}");
    randomsum = randomsum + myRandomNum;
}

Console.WriteLine($"random sum total:{randomsum}");

