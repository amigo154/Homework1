// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делиться ли оно на два без остатка)

Console.WriteLine("Здравствуйте, Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) 
    Console.Write($"Число {number} является четным");
    else 
    Console.Write($"Число {number} является нечетным");