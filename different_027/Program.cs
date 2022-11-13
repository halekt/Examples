// Вычислить число a в степени n

int PowerFor( int a, int n) // a - число, n - степень
{
    int result = 1;
    for( int i = 1; i <= n; i++) result *=a; // запустили счетчик от 1 до n, где a умножаем на a количество n раз
    return result;
}
System.Console.WriteLine(PowerFor(2, 10)); // задали условие 2 в степени 10 ?

int PowerRec(int a, int n) // 
{
    if(n ==0) return 1; // выход из рекурсии
    else return PowerRec(a, n-1) * a; // рекурсия 
}
System.Console.WriteLine(PowerRec(2,10));

int PowerRecMath(int a, int n)
{
    if( n ==0) return 1;
    else if( n % 2 == 0) return PowerRecMath(a*a, n/2);
    else return PowerRecMath (a, n-1)*a;
}
System.Console.WriteLine(PowerRecMath(2,10));