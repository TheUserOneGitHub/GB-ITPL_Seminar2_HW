// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter a week day number");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 7 && num >= 6)
{
    Console.WriteLine("The day is a weekend day");  
}
else if (num >= 1 && num <= 5)
{
    Console.WriteLine("The day is a weekday");
} 
else
{
Console.WriteLine("The number is not a day of week");
}