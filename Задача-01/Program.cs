/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите число 1 ");
string namber1 = Console.ReadLine ();
Console.WriteLine("Введите число 2 ");
string namber2 = Console.ReadLine();
int num1 = int.Parse(namber1);
int num2 = int.Parse(namber2);

if(num1 > num2)
   Console.WriteLine($"{num1} = Максимальное число");
else
   Console.WriteLine($"Максимальное число = {num2}");
  


