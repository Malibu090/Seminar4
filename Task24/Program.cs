// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// пишем функцию(метод) DataEntry, которая принимает на вход число
int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// создаем функцию(метод) 
int FindSum(int num)
{// пишем цикл, который суммирует числа от 1 до А
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {// каждый раз мы складваем следующее число(суммируем каждый итератор)
        sum = sum + i;
    }
    return sum; // возвращаем sum в 14 строчку в функцию(метод) FindSum
}

// получить число А(чтобы его получить пишем функцию DataEntry)
int number = DataEntry("Введите число A: ");
// вывести сумму из метода FindSum
int result = FindSum(number);
Console.WriteLine("Сумма чисел от 1 до А равна " +result); // выводим результат

