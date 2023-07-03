// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int len = 3;
int pos = 0;
Console.WriteLine($"Начальный массив: [{string.Join(", ", arrayStrings)}]");

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
    }
}

void PrintArray(string[] array)
{
    // Console.Write("Конечный массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        // Console.Write(array[i] + ",");
    }
    // Console.WriteLine("Конечный массив: " + '[' + string.Join(", ", array) + ']');
    Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

    // Console.Write("]");
    // Console.WriteLine();
}