// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;

for(int i = 1; i < B; i++)
{
    result = result * A;
}
Console.WriteLine($" число {A} в степени {B} равно {result} ");
