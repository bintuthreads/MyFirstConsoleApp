//Task 1 – Student Score Analyzer

/*int[] scores = { 45, 70, 55, 30, 90, 60 };
int highest = scores[0];
for(int i = 0; i < scores.Length; i++)
{
    if(scores[i] > highest)
    {
        highest = scores[i];
    }
}
Console.WriteLine($"Highest score is {highest}");
int lowest = scores[0];
for(int i = 0; i < scores.Length; i++)
{
    if(scores[i] < lowest)
    {
        lowest = scores[i];
    }
}*/
/*Console.WriteLine($"Lowest score is {lowest}");
int sum = 0;

for(int i = 0; i < scores.Length; i++)
{
    sum = sum + scores[i];
}
double average = sum / (double)scores.Length;
Console.WriteLine($"Average score is {average}");
int count = 0;

for(int i = 0; i < scores.Length; i++)
{
    if(scores[i] > average)
    {
        count++;
    }
}
Console.WriteLine($"Count is {count}");
for(int i = 0; i < scores.Length; i++)
{
    if(scores[i] >= 50)
    {
        Console.WriteLine("Student " + (i+1) + " Passed");
    }
    else
    {
        Console.WriteLine("Student " + (i+1) + " Failed");
    }
}*/

//Task 2 – Array Filter and Reverse
int[] temps = { 25, 32, 28, 35, 40, 22 };
Console.WriteLine("All Temperatures:");

for (int i = 0; i < temps.Length; i++)
{
    Console.Write(temps[i] + " ");
}
Console.WriteLine("\nTemperatures above 30:");

for (int i = 0; i < temps.Length; i++)
{
    if (temps[i] > 30)
    {
        Console.Write(temps[i] + " ");
    }
}
Console.WriteLine("\nReversed temperatures:");

for (int i = temps.Length - 1; i >= 0; i--)
{
    Console.Write(temps[i] + " ");
}
int sum = 0;

for (int i = 0; i < temps.Length; i++)
{
    sum += temps[i];
}

double average = (double)sum / temps.Length;

Console.WriteLine("\nAverage Temperature: " + average);
