// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// пишем функцию(метод), которая принимает на вход число(интовая функция со строкой внутри)
int EnterNumber(string str)
{
    Console.WriteLine(str); // выводим консоль со строкой
    int number = int.Parse(Console.ReadLine()); // вводим переменную, которой присваиваем конвертируемую в число строку
    return number; // возвращаем number в EnterNumber
}
// пишем функцию(метод) для суммы цифр в числе
int FindCount(int num)
{
    int count = 0; // вводим переменную count для счетчика количества цифр
    for (int i = 0 ; num > 0 ; i++) // создаем цикл для поиска количества цифр в числе
    {
        num = num / 10; // делим число на 10 пока число не станет вещественным
        count++; // записываем в count сколько раз пройдет цикл
    }
    return count; // возвращаем 
}

int number = EnterNumber("Введите число "); // ОБЯЗАТЕЛЬНО вводим переменную number для ввода числа
int result = FindCount(number); // вводим переменную result которой присваиваем значение из метода FindCount
Console.WriteLine("Количество цифр в числе равно " +result); // выводим ответ

// возможно решение просто с итой, но ее надо объявить до цикла for например
// int i или int i = 0
// for (i = 0; i < length; i++) тогда в for i = 0 или i {}

// решение через строку
// string DataEntry(string str) // метод DataEntry строка для ввода пользователем
// {
//     Console.WriteLine(str); // вызов ввода 
//     string number = Console.ReadLine(); // вводим строковую переменную number 
//     return number; // возвращаем number в DataEntry
// }

// string number = DataEntry("Введите ваше число "); // строке number присваиваем вызов функции DataEntry
// int lng = number.Length; // интовая переменная lng присваиваем значение длины строки 
// Console.WriteLine("количество цифр в числе " + number + " равно " + lng);