// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество
//  чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Prompt(string msg)
{

    Console.Write(msg); //Выводим приглашение ко вводу
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат

}
//метод для получения случайных значений массива
int[] Array(int Length)
{

    int[] array = new int[Length];//объявляем массив 
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(100, 1000); //заполняем случайными
        //цифрами из диапазона SatrArr до EndArr

    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
        }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");

}

int length = Prompt("Длинна массива: ");
int[] array = Array(length);
PrintArray(array);
int [] array1 = array;
int x = 0;
for (int j = 0; j < length; j++)
{
 if (array[j] % 2 == 0) 
 {
    x=x+1;
 }  
}
Console.WriteLine("Количество четных элементов в массиве: ");
Console.WriteLine(x);


