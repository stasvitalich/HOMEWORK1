Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = number % 2;
if(result > 0)
{
Console.WriteLine($"Число {number} является нечётным");
}

else
{
    Console.WriteLine($"Число {number} является чётным");
}



