namespace Language_Integrated_Query;

public class FilteringOperators
{
    public static void Run(int[] array)
    {
        var evenNumbers = array.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

        var numbersGreaterThanFive = array.Where(n => n > 5);
        Console.WriteLine("Numbers greater than five: " + string.Join(", ", numbersGreaterThanFive));
        
        var integerNumbers = array.OfType<int>();
        Console.WriteLine("Integer numbers: " + string.Join(", ", integerNumbers));
    }
}