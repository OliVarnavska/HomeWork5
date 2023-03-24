// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных 
// позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
        array[i] = random.Next(-100, 100); //заполняем случайными
        //цифрами из диапазона SatrArr до EndArr

    }

    return array;
}
// int count = 0;
// if ( array[i] % 2 == 0) count = count+1;

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
 int Sum = 0;
 for (int j = 0; j < length; j++)
 {
  if (j % 2 == 0) 
  {
     Sum=Sum+array1[j];
  }  
 }
 Console.WriteLine("Сумма четных элементов, стоящих на четных позициях: ");
 Console.WriteLine(Sum);