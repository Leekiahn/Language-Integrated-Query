namespace Language_Integrated_Query;

public class SetOperators
{
    public static void Run()
    {
        int[] array1 = new[] { 1, 10, 5, 3, 2 };
        int[] array2 = new[] { 3, 4, 5, 7, 8 };

        int[] array3 = new[] { 10, 10, 4, 5, 6, 7, 7 };

        var distinct = array3.Distinct();   // 중복 제거
        Console.WriteLine(string.Join(", ", distinct));
        
        var union = array1.Union(array2);    // 합집합
        Console.WriteLine(string.Join(", ", union));

        var intersect = array1.Intersect(array2); // 교집합
        Console.WriteLine(string.Join(", ", intersect));

        var except = array1.Except(array2); // 차집합
        Console.WriteLine(string.Join(", ", except));

    }
}