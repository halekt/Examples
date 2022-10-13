// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Вид 1
/*
void Method1()
{
    Console.WriteLine("Автор ");
}

Method1();
*/

// Вид 2
/*
void Method2(string msg )
{
    Console.WriteLine(msg);
}
//Method2(msg;  "Текст сообщения ")

void Method21(string msg, int count)
{
    int i = 0;
    while( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст");
*/

// Вид 3
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Вид 4
/*
string Method4( int count, string text)    // строку с будем возвращать  count раз
{
    int i = 0;
    string result = String.Empty; // String.Empty это пустая строка

    while( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "йцук");
Console.WriteLine(res);

*/

// Цикл  for
/*
string Method4( int count, string text)    // строку с будем возвращать  count раз
{
    string result = String.Empty; // String.Empty это пустая строка

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

*/

// Цикл в цикле

for( int i = 2; i <= 10; i++)
{

    for( int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    
    Console.WriteLine(); // искусственный разрыв строк вывода 

}

