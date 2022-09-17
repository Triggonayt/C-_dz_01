// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.Clear();
// Console.Write("Enter number1: ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number2: ");

// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine(num1 + " A larger number");
//     Console.WriteLine(num2 + " Smaller number");
// }
// else
// {
//     Console.WriteLine(num2 + " A larger number");
//     Console.WriteLine(num1 + " Smaller number");
// }





//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Clear();
// Console.WriteLine("Enter number1: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number2: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number3: ");
// int n3 = Convert.ToInt32(Console.ReadLine());

// if (n1 >= n2)
// {
//     if (n1 >= n3)
//         Console.WriteLine(n1 + "BIG");
// }
// if (n2 >= n1)
// {
//     if (n2 >= n3)
//         Console.WriteLine(n2 + "BIG");
// }
// if (n3 >= n2)
// {
//     if (n3 >= n1)
//         Console.WriteLine(n3 + "BIG");
// }





// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)


// Console.Clear();
// Console.WriteLine("Enter number: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// if ( n1 % 2 == 0)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Odd");
// }





// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < n+1)
{
    Console.Write(i++ + " ");  
    i++;
}