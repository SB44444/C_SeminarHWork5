/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomArray(int size)
{
   int[] array = new int [size];         
   for(int i = 0; i < size; i++)        
        array[i] = new Random().Next(100, 1000);      
    return array;      
}
void ShowArray(int[] array)
{   
    int count = 0;    
    Console.WriteLine("Your Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    Console.WriteLine($"The number of positive digits in your Array: {count}");       
}
Console.WriteLine("Input size of your array");
int sizeA = Convert.ToInt32(Console.ReadLine());
int[] myRandomArray = RandomArray(sizeA);
ShowArray(myRandomArray);
*/
//Задача 34 Способ 2 через функцию по подсчету четных чисел
/*
int[] RandomArray(int size)
{
   int[] array = new int [size];         
   for(int i = 0; i < size; i++)        
        array[i] = new Random().Next(100, 1000);      
    return array;   
}    
void ShowArray(int[] array)
{       
    Console.WriteLine("Your Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();   
}
int CounterPositivDigitsArray(int[] array)
{   
    int count = 0;       
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    Console.WriteLine($"The number of positive digits in your Array: {count}");        
    return count;        
          
}
Console.WriteLine("Input size of your array");
int sizeA = Convert.ToInt32(Console.ReadLine());
int[] myRandomArray = RandomArray(sizeA);
ShowArray(myRandomArray);
CounterPositivDigitsArray(myRandomArray);
*/
//   Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] RandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int [size];         
   for(int i = 0; i < size; i++)        
        array[i] = new Random().Next(minValue, maxValue);      
    return array;      
}
void ShowArray(int[] array)
{       
    Console.WriteLine("Your Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();   
}
void SumNegotivIndexElementsInArray(int[] array)
{   
    int count = 0;    
    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0)
        count += array[i];    
    Console.WriteLine($"The sum of negotive cells in your Array: {count}");       
}
Console.WriteLine("Input size of your array");
int sizeA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min digit of your array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max digit of your array");
int max = Convert.ToInt32(Console.ReadLine());
int[] myRandomArray = RandomArray(sizeA, min, max);
ShowArray(myRandomArray);
SumNegotivIndexElementsInArray(myRandomArray);
*/
/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.*/
/*
double [] RandomArray(int size, int digit, double minValue, double maxValue)
{
   double [] array = new double  [size];// Создание массива
   double decim = Convert.ToDouble(digit);// Преобразуем в double   
   Int32 dec = Convert.ToInt32(Math.Pow(10, decim));//Нужное ко-во знаков после запятой
   minValue = Math.Round(minValue,size); // Округляем параметр нижней границы
   minValue *= dec; // Целое число для метода Random.Next
   int minV = Convert.ToInt32(minValue); // Преобразуем в Int   
   maxValue = Math.Round(maxValue,size); // Округляем параметр верхней границы
   maxValue *= dec; // Целое число для метода Random.Next
   int maxV = Convert.ToInt32(maxValue);// Преобразуем в Int   
   for(int i = 0; i < size; i++)      
       
       array[i] = Math.Round((new Random().NextDouble() * (new Random().Next(minV, maxV))) /  dec, digit); // Округляем до заданного количества 
       // знаков после запятой в массиве случайную величину       
    return array;      
}
void ShowArray(double[] array)
{       
    Console.WriteLine("Your Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
    Console.WriteLine();   
}
void MaxMinDifferanceInArray(double[] array)
{   
    double maxCell = array[0];
    double minCell = array[0];       
    for(int i = 0; i < array.Length; i++)
        if(array[i]  > maxCell)
        maxCell = array[i];
    for(int i = 0; i < array.Length; i++)
        if(array[i]  < minCell)
        minCell = array[i];    
    Console.WriteLine($"The difference from minimum to maximum digits in your Array: {maxCell - minCell}");       
}

Console.WriteLine("Input size of your array");
int sizeA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of decimal place in your array");// количество знаков после запятой в массиве
int sizeDec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum digit of interval in your array");
double  min = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the maximum digit of interval in your array");
double max = Convert.ToDouble(Console.ReadLine());
double[] myRandomArray = RandomArray(sizeA, sizeDec, min, max);
ShowArray(myRandomArray);
MaxMinDifferanceInArray(myRandomArray);
*/