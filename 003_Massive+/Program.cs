int[] array = {1, 2, 33, 92, 65, 6, 67, 8, 92};

int n = array.Length;
int find = 92;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}