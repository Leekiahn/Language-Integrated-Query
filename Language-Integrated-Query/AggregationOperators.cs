namespace Language_Integrated_Query;

public class AggregationOperators
{
    private static readonly int[] Array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
    public static void Run()
    {
        var multipleAll = Array.Aggregate((a, b) => a * b);
        Console.WriteLine(string.Join(", ", multipleAll));

        var nums2 = Array.Aggregate((a, b) => a + b);
        Console.WriteLine(string.Join(", ", nums2));

        var nums3 = Array.Sum(n => n);
        Console.WriteLine(string.Join(", ", nums3));

        var min = Array.Min(n => n);
        Console.WriteLine(string.Join(", ", min));

        var max = Array.Max(n => n);
        Console.WriteLine(string.Join(", ", max));

        var average = Array.Average(n => n);
        Console.WriteLine(string.Join(", ", average));

        var count = Array.Count(n => n % 2 == 0);
        Console.WriteLine(string.Join(", ", count));

        var evenNumbersAverage = Array.Where(n => n % 2 == 0).Average(n => n);
        Console.WriteLine(string.Join(", ", evenNumbersAverage));
    }
}