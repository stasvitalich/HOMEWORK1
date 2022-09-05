//Инициализируем ввод числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//При помощи % проверяем
//делится ли введённое число на 2 без остатка 
//и вводим новую переменную result
int result = number % 2;

//Если result больше нуля, то число нечётное. 
//Если result равно нулю, то число чётное.
if(result > 0)
{
    Console.WriteLine($"Число {number} является нечётным");
}

else
{
    Console.WriteLine($"Число {number} является чётным");
}



