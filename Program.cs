
/*Задача 1: Задайте одномерный массив
 из 10 целых чисел от 1 до 100. 
 Найдите количество элементов массива, 
 значения которых лежат в отрезке [20,90].
 */
//  Console.Clear();

// int[] FillArray(int size) 
//  {
//     int[] array = new int [size];
//     for(int i =0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array; 
// }
// int lengthArray = 10;
// int[] arr = FillArray(lengthArray);
// Console.WriteLine(string.Join(" ", arr));
// for(int i = 0; i < arr.Length; i++)
// {
//     if ( arr[i] > 20 && arr[i] < 90)
//     {
//         Console.Write($"{arr[i]} ");
//     }

// }

/*  Задача2: Задайте массив на 10 целых чисел. 
Напишите программу, которая определяет количество 
чётных чисел в массиве.
*/
/* Console.Clear();

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
int count = 0;
Console.WriteLine(string.Join(" ", arr));
for(int i = 0; i < arr.Length; i++)
{
if(arr[i] % 2 == 0 )
{
    count = count +1;
}
}
Console.WriteLine($"В массиве {count} целых чисел");
*/

/* Задача 3: Задайте массив из вещественных чисел с
ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива.
*/
Console.Clear();
double[] FillArray(int size) 
 {
    double[] array = new double [size];
    for(int i =0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
        array[i] = Math.Round(array[i], 2);
    }
    return array; 
}
int lengthArray = 10;
double[] arr = FillArray(lengthArray);
Console.WriteLine(string.Join(" ", arr));
double min = arr[0];
double max = arr[0];
for(int i =1; i < arr.Length; i++)
{
    if(arr[i] < min)
    {
    min = arr[i];
    }
    else
    {
    if (arr[i] > max)
    {
        max = arr[i];
    } 
    }
}
Console.WriteLine($" Разница между {min} и {max} = {max - min}");

/*Задача 4**(не обязательно): Дано натуральное
число в диапазоне от 1 до 100 000. Создайте массив,
состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе
массива, младший – на последнем. Размер массива
должен быть равен количеству цифр.
*/