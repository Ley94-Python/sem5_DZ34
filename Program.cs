﻿
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] FillArray(int size)
{

int[] arr = new int[size];

for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(99, 999);
}
return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));
uint evenNumbersCount = 0; // счетчик для четных чисел в массиве
for(int i = 0; i < array.Length; i++)

{
    if (array[i] % 2 == 0)
    {
        evenNumbersCount++;
    }
array [i]++;
}

Console.WriteLine($"Количество четных чисел: " + evenNumbersCount);
