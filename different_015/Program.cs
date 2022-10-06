// Выводит случайное число из отрезка [10,9999] и показывает наибольшую цифру числа

int num = new Random ().Next(1, 9999);
Console.WriteLine(num);

int max = 0;
int temp =0;
int temp2=0;

while( num != 0) // != означает не равно
{
    temp = num%10; // %10 выводит последнюю цифру числа
    if(temp > max) max = temp;
    num = num/10; // /10 убирает последную цифру чисел
}

Console.WriteLine(max);