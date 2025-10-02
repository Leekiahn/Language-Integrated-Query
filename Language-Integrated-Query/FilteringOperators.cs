namespace Language_Integrated_Query;

public class FilteringOperators
{
    private static readonly int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private static readonly object[] MixedArray = new object[] { 1, 'a', 2, 'b', 3, 'c' };
    
    public static void Run()
    {
        Console.WriteLine("-----------필터링----------");
        Console.WriteLine("정수형 배열 : " + string.Join(", ", Array));
        Console.WriteLine("정수와 문자 배열 : " + string.Join(", ", MixedArray));
        
        var evenNumbers = Array.Where(n => n % 2 == 0);
        Console.WriteLine("짝수 필터링 : " + string.Join(", ", evenNumbers));

        var oddNumbers = Array.Where(n => n % 2 == 1);
        Console.WriteLine("홀수 필터링 : " + string.Join(", ", oddNumbers));

        var intNumbers = MixedArray.OfType<int>();
        Console.WriteLine("정수 필터링 : " + string.Join(", ", intNumbers));

        var characters = MixedArray.OfType<char>();
        Console.WriteLine("문자 필터링 : " + string.Join(", ", characters));
        
        Console.WriteLine("-----------------------");

        var nums2 = Array.Where(n => n * 2 > 10);
        Console.WriteLine(string.Join(", ", nums2));

    }
}