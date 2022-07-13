﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = new int [10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
}
    for (int k = 0; k < array.Length; k++)
    {
        if ((array[k] % 2) != 0)
        {
            sum += array[k];
        }
    }

Console.WriteLine($"Массив: [{String.Join("; ", array)}]"); 
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна: {sum}");


