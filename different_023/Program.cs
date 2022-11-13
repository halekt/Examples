// Рекурсия Фибоначи

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2); // иначе возвращенное число n складываем число  плюс предыдущее число
}

for(int i =1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); 
}
