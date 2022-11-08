// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
SumNumbers(n);
int sum = 0;
void SumNumbers(int n)
{
    int x = 0;
    while (n % 10 > 0)
    {
        x++;
        n /= 10;
    }
    Console.WriteLine(x);
}
while (n !=0)
{
        sum += n % 10;
        n = n / 10;
}
Console.WriteLine($"Сумма чисел {sum}") ;


