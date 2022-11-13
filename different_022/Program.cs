// Рекурсия факториал

int Factorial(int n)
{
    // 1! = 1 один факториал равно 1
    // 0! = 1 ноль факториал равно 1
    if(n ==1) return 1;                 // если n равно 1 тогда n равно 1
    else return n * Factorial(n-1);     // иначе возвращенное число n умножить на само себя минус 1
}
Console.WriteLine(Factorial(5)); // факториал 3 это 1*2*3 = 6


/*
double Factorial(int n)
{
    if(n ==1) return 1;                 // если n равно 1 тогда n равно 1
    else return n * Factorial(n-1);     // иначе возвращенное число n умножить на само себя минус 1
}
for(int i =1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}"); 
}
*/