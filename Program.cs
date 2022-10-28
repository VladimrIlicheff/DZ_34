/*Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] RandomArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < 10; i++)
        array[i] = rnd.Next(100, 1000);

    return array;
}
//создали массив из 10  случайных трёхзначных чисел 

void PrintArray(int[] array)
{

    for (int i = 0; i < 10; i++)
        Console.Write($"{array[i]} ");
}
// напечатать массив

int EvenNum(int[] array)
{
    int counter = 0;
    for (int i = 0; i < 10; i++)
        if (array[i] % 2 == 0)
            counter++;
    return counter;
}
//считаем количество чётных чисел

int[] array = RandomArray();
PrintArray(array);
Console.WriteLine("");
int counter = EvenNum(array);
Console.WriteLine($"ЧЁТНЫХ ЧИСЕЛ --->>> {counter}");
