//tetris

/* int height = 20;
int width = 10;
int [,] field = new int[height,width];
int [,] line = new int[,]
{
    {1,1,1,1},
    {0,0,0,0},

};
int [,] square = new int[,]
{
    {1,1,0,0},
    {1,1,0,0},
};
int [,] zet = new int[,]
{
    {1,1,0,0},
    {0,1,1,0},
};
int [,] te = new int[,]
{
    {0,1,0,0},
    {1,1,1,0},
};
int [,] poker = new int[,]
{
    {1,0,0,0},
    {1,1,1,0},

};
void Appear(int pos_y, int pos_x, int [,]fig)
{
    for (int i = pos_y; i < 2; i++)
    {
        for (int j = pos_x; j < 4; j++)
        {
            if (field[i,j] == 0) field[i,j] = fig[i-pos_y, j-pos_x];
            else break;
        }
    }
}
void Print(int [,]act_array)
{
    for (int i = 0; i < act_array.GetLength(0); i++)
    {
        for (int j = 0; j < act_array.GetLength(1); j++)
        {
            if (act_array[i,j] == 1) Console.Write("[]");
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
}
int Generation ()
{
    int figure = new Random().Next(1,6) ;
    return figure;
}

if (Generation() == 1) Appear(0,0, line);
if (Generation() == 2) Appear(0,0, square);
if (Generation() == 3) Appear(0,0, zet);
if (Generation() == 4) Appear(0,0, te);
if (Generation() == 5) Appear(0,0, poker);
Print(field);
for (int i = height; i > 0; i--)
{
    
} */
//Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
double [] array = new double[20];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() *1000, 3);
}
void PrintArray(double [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]}   ");
    }
}
PrintArray(array);
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
    {
        
    }
}
Console.WriteLine();
Console.WriteLine($"Max = {max}; Minimum = {min}");
Console.WriteLine("Разница между макс и мин = " + Math.Round((max - min),3));
