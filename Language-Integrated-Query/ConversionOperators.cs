namespace Language_Integrated_Query;

public class ConversionOperators
{
    public static void Run()
    {
        List<int> list = new List<int>();
        int[] array = new int[5];

        var listToArray = list.ToArray();
        var arrayToList = array.ToList();

        int[] numbers = new[] { 1, 2, 3, 4, 5, 6 };

        var num2 = numbers.ToDictionary(n => n, n => n * n);
        foreach (var item in num2)
        {
            Console.WriteLine($"Key : {item.Key}, Value : {item.Value}");
        }

        var num3 = numbers.ToLookup(n => n % 2 == 0 ? "even" : "odd");
        foreach (var item in num3)
        {
            Console.WriteLine($"Key : {item.Key}");
            foreach (var i in item)
            {
                Console.WriteLine($"Value : {i}");
            }
        }

        string[] numberTexts = new[] { "1", "2", "3" };
        var intCast = numbers.Cast<int>();
        Console.WriteLine(string.Join(", ", intCast));
    }
}