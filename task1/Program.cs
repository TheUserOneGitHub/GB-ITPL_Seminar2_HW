// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

Console.WriteLine("Enter a three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = num * -1;
}
int num_test = num / 100;
// Console.WriteLine(num_test);

if (num_test <= 0)
{
    Console.WriteLine($"The number {num} is not a three-digit number");
}
else if (num_test >= 10)
{
    Console.WriteLine($"The number {num} is not a three-digit number");
}
else
{
    int num1 = num % 100;
    // Console.WriteLine(num1);
    int num2 = num1 / 10;
    Console.WriteLine($"The second digit is {num2}");
}