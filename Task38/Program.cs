// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76


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
        array[i] = random.Next(-1000, 1000); //заполняем случайными
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
 int Sum = 0;
 int Max = array1[0];
 int Min = array1[0];
 for (int j = 0; j < length; j++)
 {
  if ( Max <= array1[j] ) 
  {
    Max = array1[j];
  }
  }
  Console.WriteLine($"Максимальный элемент: {Max}");


for (int j = 0; j < length; j++)
 {
  if ( Min > array1[j] ) 
  {
   Min = array1[j];
  }
  }
  Console.WriteLine($"Минимальный элемент: {Min}");
     Sum = Max + Min;
 Console.WriteLine($"Сумма максимального элемента {Max} и минимального элемента {Min}: ");
 Console.WriteLine(Sum);