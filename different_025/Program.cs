//Сумма чисел от 1 до N используя рекурсию

int SumFor(int n) // суммируем с помощью счетчика
{
    int result = 0;
    for(int i = 1; i <= n; i++) result +=i;
    return result;
}
System.Console.WriteLine(SumFor(10));

int SumRec(int n) // суммируем с помощью рекурсии
{
    if (n == 1) return 1;
    else return n + SumRec(n-1);
}
System.Console.WriteLine(SumRec(10));