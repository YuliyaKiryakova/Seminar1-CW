/*
Напишите прогу, которая на вход принимает два числа и и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

Console.Write("Введите целое число a: ");
string numberA = Console.ReadLine()!;
Console.Write("Введите целое число b: ");
string numberB = Console.ReadLine()!;
int numA = int.Parse(numberA);
int numB = int.Parse(numberB);
/*if (numA == numB * numB)
{
    Console.WriteLine($"Квадрат числа {numB} равен {numA}");
}
else
{
Console.WriteLine($"Квадрат числа {numB} не равен {numA}");
}
*/
/*bool check = numA == numB*numB;
Console.WriteLine(check);
*/
Console.WriteLine(numA == numB * numB);