// Инициализируем ввод первого, второго и третьего числа:
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

// Введём новую переменную max и предположим,
// что наше первое число и есть максимальное. 
int max = number1;

//Проводим операцию сравнения.
//В случае если число больше предыдущего максимума,
//то переменная max перезаписывается.
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

//Выводим в консоль переменную max,
//которая и является искомым значением.
Console.WriteLine($"Наибольшим числом из трёх введенных явялется число: {max}");



















