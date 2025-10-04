namespace Language_Integrated_Query;

public class PartitioningOperators
{
    public static void Run()
    {
        int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var firstThree = numbers.Take(3); // 1, 2, 3

        var skipThree = numbers.Skip(3); // 4, 5, 6

        var takeWhile = numbers.TakeWhile(n => n < 4); // 1, 2, 3

        var skipWhile = numbers.SkipWhile(n => n < 4); // 4, 5, 6
    }
}