﻿//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = NewArray(8);
Console.WriteLine($" [ {String.Join(" // ", array)} ] ");


int[] NewArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(77);
    }

    return result;
}

