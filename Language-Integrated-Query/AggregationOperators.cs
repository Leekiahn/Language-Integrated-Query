namespace Language_Integrated_Query;

public class AggregationOperators
{
    public static void Run(int[] array)
    {
        var count = array.Where(n => n % 2 == 0).Count();
        Console.WriteLine("Count of even numbers: " + count);
        
        var sum = array.Sum();
        Console.WriteLine("Sum of all numbers: " + sum);
        
        var average = array.Average();
        Console.WriteLine("Average of all numbers: " + average);
        
        var min = array.Min();
        Console.WriteLine("Minimum number: " + min);
        
        var max = array.Max();
        Console.WriteLine("Maximum number: " + max);
        
        var aggregate = array.Aggregate((a, b) => a * b);
        Console.WriteLine("Product of all numbers: " + aggregate); // 1*2*3*...*9 = 362880
    }
}