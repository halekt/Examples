// Алгоритм масссива 

int[] array = {1, 12, 31, 4, 50, 16, 17, 18};

int n = array.Length;
int find = 50;

int index = 0;

while( index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}