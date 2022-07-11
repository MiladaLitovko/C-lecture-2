//ДВУМЕРНЫЕ МАССИВЫ

string[,] table = new string[2,5];
// String.Empty
// table[0,0]  table[0,1]   table[0,2]  
// table[1,0]  table[1,1]   table[1,2]

/*table[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    } 
}
*/


void PrintArray(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]}");
        } 
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
        } 
    }
}


int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);