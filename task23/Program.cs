// задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X не равен 0 и Y не равен 0
// и выдаёт номер четверти плоскости, в которой находится эта точка. 

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.Write("Точка лежит в первой четверти");
}
else if(x < 0 && y > 0)
{
    Console.Write("Точка лежит во второй четверти");
}
else if(x < 0 && y < 0)
{
    Console.Write("Точка лежит в третьей четверти");
}
else
{
    Console.Write("Точка лежит в четвертой четверти");
}