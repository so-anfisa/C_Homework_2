// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000)
{ 
   Console.WriteLine($"В числе {number}, второй цифрой является {number/10%10}"); 
} else
{
    Console.WriteLine($"Число {number} не является трехзначным");
}
// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Берем числа до 100000
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100 && num < 100000) {
    Console.WriteLine($"В числе {num} нет третьей цифры"); 
}
    else if (num > 99 && num < 1000) {
        Console.WriteLine($"В числе {num}, третьей цифрой является {num%10}"); 
    }
   else if (num > 999 && num < 10000) {
        Console.WriteLine($"В числе {num}, третьей цифрой является {num/10%10}"); 
    }
    else if (num > 9999 && num < 100000) {
        Console.WriteLine($"В числе {num}, третьей цифрой является {num/100%10}"); 
    }

 else
{
    Console.WriteLine($"Число {num} > 100000");
}
// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
// Обязательна проверка на ввод числа <1 и >7Console.WriteLine("Введите трехзначное число: ");

Console.WriteLine("Введите цифру, обозначающую день недели ");
int number_week = int.Parse(Console.ReadLine());

if (number_week > 0 && number_week < 8 && (number_week == 6 || number_week == 7)) {
    Console.WriteLine($"Число {number_week} является выходным днём"); 
}
else if (number_week > 0 && number_week < 6) {   
    Console.WriteLine($"Число {number_week} НЕ является выходным днём"); 
}
else {
    Console.WriteLine($"Число {number_week} не является днём недели"); 
}
