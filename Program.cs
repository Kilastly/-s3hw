﻿
/*Задача 1: Задайте одномерный массив
 из 10 целых чисел от 1 до 100. 
 Найдите количество элементов массива, 
 значения которых лежат в отрезке [20,90].
 */
 Console.Clear();

int[] FillArray(int size) 
 {
    int[] array = new int [size];
    for(int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array; 
}
int lengthArray = 10;
int[] arr = FillArray(lengthArray);
Console.WriteLine(string.Join(" ", arr));
for(int i = 0; i < arr.Length; i++)
{
    if ( arr[i] > 20 && arr[i] < 90)
    {
        Console.Write($"{arr[i]} ");
    }

}