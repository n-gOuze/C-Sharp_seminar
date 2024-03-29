﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillRandomArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 2);
    }
}

int number = 8;
int[] array = new int[number];
FillRandomArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         Console.WriteLine(collection[index]);
//         index++;
//     }
// }

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);
