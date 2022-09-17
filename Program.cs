// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Clear();
Console.Write("Enter number1: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number2: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1 + " A larger number");
    Console.WriteLine(num2 + " Smaller number");
}
else
{
    Console.WriteLine(num2 + " A larger number");
    Console.WriteLine(num1 + " Smaller number");
}
