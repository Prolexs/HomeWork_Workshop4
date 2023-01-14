 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(A > 0)
{
    int num = A % 10;
    A = A / 10;
    sum = sum + num;
}
Console.WriteLine($"сумма всех цифр данного числа равна {sum} ");