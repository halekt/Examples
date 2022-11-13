// Собрать строку с числами от a до b a <= b используя рекурсию

string NumbersFor(int a, int b)
{
    string result = String.Empty; // String.Empty - пустая строка
    for (int i = a; i <= b; i++) // вариант 1 используя счетчик 
    {
        result += $"{i} ";
    }
    return result;
}
System.Console.WriteLine(NumbersFor(1, 10)); // вывод в терминале от 1 до 10

string NumbersFor2(int a, int b)
{
    string result = String.Empty; // String.Empty - пустая строка
    for (int i = a; i >= b; i--) // вариант 1 используя счетчик 
    {
        result += $"{i} ";
    }
    return result;
}
System.Console.WriteLine(NumbersFor2(1, 10)); // вывод в терминале от 1 до 10



string NumbersRec( int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b); // вариант 2 используя рекурсию. return $"{a} - рекурсия a
    else return String.Empty;
}
System.Console.WriteLine(NumbersRec(1, 10));

string NumbersRec2( int a, int b)
{
    if (a <= b) return NumbersRec2(a + 1, b) + $"{a} "; // вариант 2 используя рекурсию. return $"{a} - рекурсия a
    else return String.Empty;
}
System.Console.WriteLine(NumbersRec2(1, 10));
