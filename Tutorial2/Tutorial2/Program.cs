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