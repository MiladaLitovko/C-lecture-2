void FiLLArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}



int Indexof(int[] collection, in find)
{
    int count = collection.Length;
    int index = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FiLLArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof[array, 4];
Console.WriteLine(pos);