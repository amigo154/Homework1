// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberThird = Convert.ToInt32(Console.ReadLine());
int maxNumber;

if (numberFirst > numberSecond)
    maxNumber = numberFirst;
else
    maxNumber = numberSecond;

if (maxNumber < numberThird)
    maxNumber = numberThird;
    
Console.Write($"Из чисел {numberFirst}, {numberSecond}, {numberThird} большим является {maxNumber}");
    



    
