// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введитче число рядов: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int colCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Массив: ");

int[,] table = new int[rowCount, colCount];
var element = new Random();
for (int a = 0; a < rowCount; a++)
{
    for (int b = 0; b < colCount; b++)
    {
        table[a, b] = element.Next(0, 9);
        Console.Write($"{table[a, b]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[] rowList = new int[rowCount];
for (int row = 0; row < rowCount; row++)
{
    int sum = 0;
    for (int col = 0; col < colCount; col++)
    {
        sum = sum + table[row, col];
    }
    rowList[row] = sum;
}
PrintArray(rowList);

void PrintArray(int[] array)
{
    Console.WriteLine("Сууммы рядов:");
    for (int b = 0; b < rowCount; b++)
        {
            Console.WriteLine("Сумма чисел " + (b + 1) + "-го ряда = " + array[b]);
        }
        Console.WriteLine();
}

int min = 0;
for (int i = 0; i < rowList.Length - 1; i++) //нет проверки на то, что несколько min-рядов равны 
{
    if (rowList[min] > rowList[i + 1])
    min = i + 1;
}
Console.WriteLine($"Наименьшая сумма у ряда №{min + 1}");