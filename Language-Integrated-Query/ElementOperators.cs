namespace Language_Integrated_Query;

public class ElementOperators
{
    public static void Run()
    {
        string sentence = "Hello! My name is Phikozz! nice to meet you.";

        var word =
            from w in sentence.Split(' ')
            select w;

        var firstWord = word.First();
        Console.WriteLine(firstWord);

        var firstOrDefault = word.FirstOrDefault();
        Console.WriteLine(firstOrDefault);

        int[] a = new[] { 1 };
        var single = a.Single();
        var singleDefault = a.SingleOrDefault();
        Console.WriteLine(single);
        Console.WriteLine(singleDefault);

        var index = sentence.ElementAt(5);
        Console.WriteLine(index);
    }
}