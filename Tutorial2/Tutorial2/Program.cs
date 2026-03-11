// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Dodatek1");
Console.WriteLine("Dodatek2");
Console.WriteLine("Dodatek3");
Console.WriteLine("Dodatek4");

static double CalculateAverage(int[] numbers)
{
    double average = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        average += numbers[i];
    }
    return average / numbers.Length;
}

int[] testTab = {2,3,54,6,2};
Console.WriteLine("Average from this testTab is: " + CalculateAverage(testTab));

Console.WriteLine("Starting task 5");

static int CalculateMax(int[] numbers)
{
    return numbers.Max();
}

static int CalculateMin(int[] numbers)
{
    return numbers.Min();
}


Console.WriteLine("Ending task 6");