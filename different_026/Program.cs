// Сумма числе от 1 до n факториал числа с помощью рекурсии

int FactorialFor(int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= i;
    return result;
}
System.Console.WriteLine(FactorialFor(10));

int FactorialRec(int n)
{
    if( n==1) return 1; // выход из рекурсии
    else return n * FactorialRec(n-1); // рекурсия факториала суммирования чисел
}
System.Console.WriteLine(FactorialRec(10));