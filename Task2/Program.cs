﻿// Инициализируем ввод первого и второго числа:
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

//Вводим условие, сравнивая между собой первое и второе число. 
//Если первое число больше, то выводим его. 
if (number1 > number2)
{
    Console.WriteLine($"Из двух введённых чисел большим является число: {number1}");
}

//Если второе число больше, то выводим его. 
else
{
    Console.WriteLine($"Из двух введённых чисел большим является число: {number2}");
}


