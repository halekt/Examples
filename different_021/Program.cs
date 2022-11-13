// Двумерные массивы 
/*
string[,] table = new string[2, 5]; // указали что в массиве будет 2 строки и 5 столбцов 
table[1, 2] = "слово"; // обращаемся к индексу элемента массива

// table [0, 0] table [0, 1] table [0, 2] table [0, 3] table [0, 4] обращение к столбцам
// table [1, 0] table [1, 1] table [1, 2] table [1, 3] table [1, 4] обращение к строкам

for(int rows =0; rows < 2; rows++) // указана 2 потому что в массиве 2 строки 
{
    for(int colums =0; colums<5; colums++) // указана 5 потому что в массиве 5 столбцов 
    {
        Console.WriteLine($"-{table[rows, colums]}-"); // обращаемся к масиисву строк и столбцов
    }
}
*/

/*
int[,] table = new int[2, 5]; // указали что в массиве будет 2 строки и 5 столбцов 

for(int rows =0; rows < 2; rows++) // указана 2 потому что в массиве 2 строки 
{
    for(int colums =0; colums<5; colums++) // указана 5 потому что в массиве 5 столбцов 
    {
        Console.Write($"{table[rows, colums]} "); // обращаемся к масиисву строк и столбцов
    }
Console.WriteLine(); // что бы отделить числа друг от друга 
}
*/

/* 
int[,] table = new int[2, 5]; // указали что в массиве будет 2 строки и 5 столбцов 

for(int rows =0; rows < table.GetLength(0); rows++) // указали 0 потому что в массиве строки начинаются с 0 
{
    for(int colums =0; colums<table.GetLength(1); colums++) // указали 1 потому что в массиве  столбцы начинаются с 1 
    {
        Console.Write($"{table[rows, colums]} "); // обращаемся к масиисву строк и столбцов
    }
Console.WriteLine(); // что бы отделить числа друг от друга 
}
*/

void PrintArray(int[,] tab) // передали данные массива в  PrintArray для вывода на экран
{
for(int rows =0; rows < tab.GetLength(0); rows++) // указали 0 потому что в массиве строки начинаются с 0 
{
    for(int colums =0; colums<tab.GetLength(1); colums++) // указали 1 потому что в массиве  столбцы начинаются с 1 
    {
        Console.Write($"{tab[rows, colums]} "); // обращаемся к масиисву строк и столбцов
    }
Console.WriteLine(); // что бы отделить числа друг от друга 
}
}

void FillArray (int[,] tab) // передали данные массива в  PrintArray для вывода на экран
{
for(int rows =0; rows < tab.GetLength(0); rows++) // указали 0 потому что в массиве строки начинаются с 0 
{
    for(int colums =0; colums<tab.GetLength(1); colums++) // указали 1 потому что в массиве  столбцы начинаются с 1 
    {
        tab[rows, colums] = new Random().Next(1,10); // Заполнели массив числами
    }
}
}

int[,] table = new int[2, 5]; // указали что в массиве будет 2 строки и 5 столбцов 
PrintArray(table); // вывод данных массива на экран
FillArray(table);
Console.WriteLine(); // что бы отделить стобцы друг от друга 
PrintArray(table); // вывод заполненных данных массива на экран 