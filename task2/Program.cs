// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большшее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)    
System.Console.WriteLine("Большее число: " + b + ", меньшее число: " + a);
else System.Console.WriteLine($"Большее число: {b}, меньшее число: {a}");








