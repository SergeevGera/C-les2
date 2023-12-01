//__________________________________Задание 1__________________________________|
//                                                                             |
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// Пример:
// Массив [10 21 14 93 23] => 2


// int[] array = new int[10];
// int i = 0;
// int result = 0;
// for (i = 0; i < 10; i++)
// {
//     array[i] = new Random().Next(1, 100);
//     Console.WriteLine(array[i] + " ");
// }
// foreach (int number in array)
// {
//     if (number >= 20 && number <= 90)
//     {
//         result++;
//     }
// }
// Console.Write($"Чисел в этом промежутке: {result}");


//__________________________________Задание 2__________________________________|
//                                                                             |
// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

// Пример:
// Массив [6 7 19 34 3 1 4 7 9 1] => 3
// Массив [1 8 43 4 55 60 3 2 1 3] => 4

using System.Globalization;

int[] array = new int[10];
int i = 0;
int result = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    System.Console.WriteLine(array[i] + " ");
}
foreach (int number in array)
{
    if (number % 2 == 0)
    {
        result++;
    }
}
System.Console.Write($"Колличество четных чисел в массиве = {result}");