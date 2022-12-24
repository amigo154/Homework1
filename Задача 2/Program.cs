// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
    Console.Write($"Число {numberFirst} является большим");
else
    Console.Write($"Число {numberSecond} является большим");