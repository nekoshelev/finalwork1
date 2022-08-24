// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массива

string[] array = new string[] { "geekbrains", "gb", "skill", "red", "123" };

void methodArray(string[] array)
{
    Console.Write("[ ");
    string[] arr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[i] = array[i];
            Console.Write($"{arr[i]} ");
        }
    }
    Console.Write("]");
}

void Print(string[] Array)
{
    Console.Write("[ ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        Console.Write(" ");
    }
    Console.Write("]");
}
Console.WriteLine();
Console.WriteLine("Заданный массив: ");
Print(array);

Console.WriteLine();
Console.WriteLine("Результат: ");
methodArray(array);
