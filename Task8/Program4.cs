﻿//Производим инициализацию числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//Даём понять пользователю, что программа работает с числами больше 2
if (number < 2)
{
    Console.Write("Программа работает с числами больше ");
}

//Определяем первоначальное число для вывода. 
//Оно всегда равно 2. Выводим его.
int startNumber = 2;
Console.WriteLine(startNumber);

//Запускаем цикл. 
//До тех пор пока стартовое число меньше, чем первоначальное -1,
//прибавляем к нему двойку. 

while (startNumber < number - 1)
{
    startNumber = startNumber + 2;
    Console.WriteLine(startNumber);
}

