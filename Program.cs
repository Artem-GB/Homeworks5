//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] RandomArray(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }
    return myArray;
}


void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CountsEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());

int [] myArray = RandomArray(a);
ShowArray(myArray);
int result = CountsEven(myArray);
Console.WriteLine($"В этом массиве количество четных чисел -> {result}");
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SumElements(int[] array)
{   
    int result = 0;
    for(int i = 0; i < array.Length; i = i + 2)
    {
        result = result + array[i];
               
    }
    return result;

}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = RandomArray(a, min, max);
ShowArray(myArray);
int result = SumElements(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {result}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int DifferenceMaxMin(int[] array, int max)
{   
    int max1 = 0;
    int min = max;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max1 = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
                
    }
    result = max1 - min;
    return result;
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = RandomArray(a, min, max);
ShowArray(myArray);
int result = DifferenceMaxMin(myArray, max);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {result}");