namespace Language_Integrated_Query;

public class JoinOperators
{
    public static void Run()
    {
        Student[] students = new[]
        {
            new Student("홍길동", 90),
            new Student("김명자", 70),
            new Student("옥동자", 80),
            new Student("박선호", 60),
            new Student("홍준영", 50),
        };

        StudentSubject[] studentScores = new[]
        {
            new StudentSubject("홍길동", "국어"),
            new StudentSubject("홍길동", "수학"),
            new StudentSubject("김명자", "국어"),
            new StudentSubject("옥동자", "영어"),
            new StudentSubject("박선호", "사회"),
            new StudentSubject("홍준영", "역사"),
        };
        
        // 내부 조인
        // var studentScoreJoin = students.Join(
        //     studentScores, // 조인에 사용할 두 번째 컬렉션
        //     student => student.Name, // 첫 번째 컬렉션에서 조인에 사용할 키를 선택하는 람다식
        //     subject => subject.Name, // 두 번째 컬렉션에서 조인에 사용할 키를 선택하는 람다식
        //     (student, subject) => new
        //     {
        //         Name = student.Name,
        //         Score = student.Score,
        //         Subject = subject.Subject
        //     }
        // );

        var studentScoreJoin =
            from student in students
            join score in studentScores
                on student.Name equals score.Name
            select new
            {
                Name = student.Name,
                Score = student.Score,
                Subject = score.Subject
            };

        // 그룹 조인
        foreach (var item in studentScoreJoin)
        {
            Console.WriteLine($"이름: {item.Name}, 점수: {item.Score}, 과목: {item.Subject}");
        }

        // var studentScoreGroupJoin = students.GroupJoin(
        //     studentScores, // 조인에 사용할 두 번째 컬렉션
        //     student => student.Name, // 첫 번째 컬렉션에서 조인에 사용할 키를 선택하는 람다식
        //     subject => subject.Name, // 두 번째 컬렉션에서 조인에 사용할 키를 선택하는 람다식
        //     (student, subject) => new
        //     {
        //         Name = student.Name,
        //         Score = student.Score,
        //         Subject = subject.Select(n => n.Subject)
        //     }
        // );

        var studentScoreGroupJoin =
            from student in students
            join score in studentScores
                on student.Name equals score.Name into scoreGroup
            select new
            {
                Name = student.Name,
                Score = student.Score,
                Subject = scoreGroup.Select(n => n.Subject)
            };
        
        foreach (var item in studentScoreGroupJoin)
        {
            Console.WriteLine($"이름: {item.Name}, 점수: {item.Score}, 과목: {string.Join(", ", item.Subject)}");
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Student(string name, int score)
    {
        this.Name = name;
        this.Score = score;
    }
}

public class StudentSubject
{
    public string Name { get; set; }
    public string Subject { get; set; }
    

    public StudentSubject(string name, string subject)
    {
        Name = name;
        Subject = subject;
    }
}
