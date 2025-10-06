namespace Language_Integrated_Query;

public class SortingOperators
{
    public static void Run()
    {
        int[] array = new[] { 10, 8, 3, 4, 6, 7, 2, 5 };

        var ascendingSort = array.OrderBy(n => n);
        Console.WriteLine(string.Join(", ", ascendingSort));

        var descendingSort = array.OrderByDescending(n => n);
        Console.WriteLine(string.Join(", ", descendingSort));

        var ascendingSort2 = array.OrderBy(n => n > 5); // false 값이 먼저 true 값이 나중에
        Console.WriteLine(string.Join(", ", ascendingSort2));

        Child[] children = new[]
        {
            new Child("Tom", 7, 150),
            new Child("Jack", 7, 140),
            new Child("Arthur", 15, 160),
            new Child("Jimmy", 8, 145),
            new Child("Alice", 9, 152)
        };

        var Sort2 = children.OrderBy(n => n.Age).ThenBy(n => n.Height);
        foreach (var item in Sort2)
        {
            Console.WriteLine($"이름 : {item.Name}, 나이 : {item.Age}, 키 : {item.Height}");
        }

        var reverse = ascendingSort2.Reverse();
        Console.WriteLine(string.Join(", ", reverse));
    }
}

public class Child
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }

    public Child(string name, int age, int height)
    {
        this.Name = name;
        this.Age = age;
        this.Height = height;
    }
}