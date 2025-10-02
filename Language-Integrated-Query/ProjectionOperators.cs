namespace Language_Integrated_Query;

public class ProjectionOperators
{
    public static void Run(int[] array)
    {
        var array1 = array.Select(n => n * n);
        Console.WriteLine(string.Join(", ",  array1));

        string[] words = new[] { "apple", "banana", "cherry" };
        var length = words.Select(n => n.Length);
        Console.WriteLine(string.Join(", ", length));
        
        People[] people = new[]{ new People("Tom", 20, new[] {90, 80} ), new People("John", 30, new[] { 60, 70 }) };
        var Names = people.Select(p => p.name); // Select : 각 요소를 변환
        var ages = people.Select(p => p.age);
        var nums = people.SelectMany(p => p.nums);  // SelectMany : 중첩된 컬렉션을 단일 컬렉션으로 평탄화
        Console.WriteLine(string.Join(", ", Names));
        Console.WriteLine(string.Join(", ", ages));
        Console.WriteLine(string.Join(", ", nums));
    }
}

public class People
{
    public string name { get; set; }
    public int age { get; set; }
    public int[] nums { get; set; }

    public People(string name, int age, int[] nums)
    {
        this.name = name;
        this.age = age;
        this.nums = nums;
    }
}