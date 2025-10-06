namespace Language_Integrated_Query;

public class GenerationOperators
{
    public static void Run()
    {
        var range = Enumerable.Range(1, 10);

        var repeat = Enumerable.Repeat(7, 5);

        var empty = Enumerable.Empty<int>();
        // Enumerable.Empty<T>()는 비어있는 시퀀스(컬렉션)를 반환할 때 사용합니다.
        //     주로 다음과 같은 상황에서 유용합니다:
        // 메서드에서 조건에 따라 빈 컬렉션을 반환해야 할 때
        // LINQ 쿼리에서 결과가 없을 때 기본값으로 사용
        // null 대신 빈 컬렉션을 반환해, 호출 측에서 null 체크 없이 foreach 등 반복문 사용 가능
    }
}