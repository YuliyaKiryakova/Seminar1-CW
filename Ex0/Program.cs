// Напищите программу, которая на вход принимает число и выдает его квадрат

System.Console.Write("Ведите целое число: ");
string number = System.Console.ReadLine()!;
int num = int.Parse(number);

int square = num * num;
System.Console.WriteLine($"Квадрат числа {num} равен {square}");
// System.Console.WriteLine(num * num);