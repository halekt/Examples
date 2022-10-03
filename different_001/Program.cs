//
Console.WriteLine("Введите числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int size = 2; // для a,b
int sum = 0;
int avg = 0;
int index = 0;
while (index < size)
{
    sum = a * b;
    
   index++;
}
Console.WriteLine($"Среднее арифметическое число {a} умножить на {b} равно {avg=sum/size}");
