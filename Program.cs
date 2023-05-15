using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("water tank: ");
        double tankCapacity = double.Parse(Console.ReadLine());

        Console.Write("average volume: ");
        double averageDrinkingVolume = double.Parse(Console.ReadLine());

        Console.Write("quantity per time: ");
        double refillVolume = double.Parse(Console.ReadLine());

        Console.Write("break time: ");
        int breakInterval = int.Parse(Console.ReadLine());

        Console.Write("interstitial time: ");
        int refillInterval = int.Parse(Console.ReadLine());

        Console.Write("total duration: ");
        int totalDuration = int.Parse(Console.ReadLine());

        int numberOfBreaks = totalDuration / (breakInterval + refillInterval);
        double totalWaterDrank = averageDrinkingVolume * numberOfBreaks;
        double totalWaterRefilled = refillVolume * numberOfBreaks;

        double remainingWater = tankCapacity - totalWaterRefilled + totalWaterDrank;

        if (remainingWater >= 0)
        {
            Console.WriteLine("Enough Water, " + remainingWater + " left");
        }
        else
        {
            if (remainingWater < 0 - refillVolume)
            {
                Console.WriteLine("Overflow Water");
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }
        }
    }
}