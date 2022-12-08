// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// создаем функцию(метод) 
int FindFak(int num)
{// пишем цикл, который суммирует числа от 1 до N
    int fak = 1;
    for (int i = 1; i <= num; i++)
    {// каждый раз мы складваем следующее число(суммируем каждый итератор)
        fak = fak * i;
    }
    return fak; // возвращаем sum в 14 строчку в функцию(метод) FindFak
}

// получить число А(чтобы его получить пишем функцию DataEntry)
int number = DataEntry("Введите число N: ");
// вывести сумму из метода FindFak
int result = FindFak(number);
Console.WriteLine("Произведение чисел от 1 до N равна " +result); // выводим результат
