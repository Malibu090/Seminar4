// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

// int[] randomArray = new int[size]; // создали массив array, состоящий из size значений
int InputSize(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] CreateArray(int[] num)
{
    int size = num.Length;
    for (int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(0, 2);
    }
    return num;
}

void PrintArray(int[] num)
{
    int count = num.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(num[i] + " ");
    }
}

int number = InputSize("Введите количество элементов ");

int[] randomArray = new int[number];

randomArray = CreateArray(randomArray);

PrintArray(randomArray);
