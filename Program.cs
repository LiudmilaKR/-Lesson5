/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Console.WriteLine ("Введите размерность массива"); 
int LenArr = int.Parse(Console.ReadLine()!); 
int[] array = GetArray(LenArr, 100, 999); 
Console.WriteLine ($"[{String.Join(", ", array)}]"); 
Console.WriteLine ($"Количество четных чисел в данном массиве составляет {CountEvenNumbers(array)}"); 

int CountEvenNumbers (int[] arr)
{
int count = 0;
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] % 2 == 0) count++;
}
return count;
}

int[] GetArray (int size, int minValue, int maxValue) 
{ 
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        res[i] = new Random().Next(minValue, maxValue + 1); 
    } 
    return res; 
}
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Console.WriteLine ("Введите размерность массива"); 
int LenArr = int.Parse(Console.ReadLine()!); 
int[] array = GetArray(LenArr, -10, 30); 
Console.WriteLine ($"[{String.Join(", ", array)}]"); 
Console.WriteLine ($"Сумма элементов, стоящих на нечетных позициях равна {SumEl(array)}"); 

int SumEl (int[] arr)
{
int sum = 0;
for (int index = 1; index < arr.Length; index = index + 2)
{
    sum = sum + arr[index];
}
return sum;
}

int[] GetArray (int size, int minValue, int maxValue) 
{ 
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        res[i] = new Random().Next(minValue, maxValue + 1); 
    } 
    return res; 
}
*/
/*
Задача 38: Задайте массив вещественных чисел (просто от минус бесконечности, до плюс бесконечности, с дробными не работаем).
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 
*/

Console.WriteLine ("Введите размерность массива"); 
int LenArr = int.Parse(Console.ReadLine()!);
// int[] array = GetArray(LenArr, -0x7fffffff, 0x7fffffff);
// int[] array = GetArray(LenArr, -10000, 10000);
int[] array = GetArray(LenArr, -Convert.ToInt32(Math.Pow(2, 30)), Convert.ToInt32(Math.Pow(2, 30))); 
Console.WriteLine ($"[{String.Join(", ", array)}]"); 

Console.WriteLine(MaxEl(array));
Console.WriteLine(MinEl(array));
int div = MaxEl(array) - MinEl(array);
Console.WriteLine(div);
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива составляет {MaxEl(array) - MinEl(array)}"); 

int MinEl (int[] arr)
{
int min = arr[0];
for (int index = 1; index < arr.Length; index++)
{
    if (arr[index] < min) min = arr[index];
}
return min;
}

int MaxEl (int[] arr)
{
int max = arr[0];
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] > max) max = arr[index];
}
return max;
}

int[] GetArray (int size, int minValue, int maxValue) 
{ 
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        res[i] = new Random().Next(minValue, maxValue); 
    } 
    return res; 
}

