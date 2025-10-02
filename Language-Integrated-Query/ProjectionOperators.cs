namespace Language_Integrated_Query;

public class ProjectionOperators
{
    private static readonly int[] Array = new[] { 1, 2, 3, 4, 5 };
    
    public static void Run()
    {
        var squaredNumbers = Array.Select(n => n * n);
        Console.WriteLine(string.Join(", ", squaredNumbers));   // 1, 4, 9, 16, 25

        Person[] people = new[]
        {
            new Person("이기안", 26, new[] { "010", "1234", "2345" }),
            new Person("홍길동", 18, new[] { "010", "3234", "5345" }),
            new Person("이명자", 40, new[] { "010", "9872", "1235" }),
        };

        var names = people.Select(n => n.Name);
        Console.WriteLine(string.Join(", ", names));   // 이기안, 홍길동, 이명자

        var ages = people.Select(n => n.Age);
        Console.WriteLine(string.Join(", ", ages));   // 26, 18, 40

        var phoneNumbers = people.SelectMany(n => n.PhoneNumber);
        Console.WriteLine(string.Join(", ", phoneNumbers));   // 010, 1234, 2345, 010, 3234, 5345, 010, 9872, 1235
    }
}

public class Person
{
    public string Name { get; private set; }
    public int Age  { get; private set; }
    public string[] PhoneNumber { get; private set; }

    public Person(string name, int age, string[] phoneNumber)
    {
        this.Name = name;
        this.Age = age;
        this.PhoneNumber = phoneNumber;
    }
}