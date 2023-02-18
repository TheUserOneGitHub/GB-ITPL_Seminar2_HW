// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

Console.WriteLine("Enter no less than three-digit integer");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) // превращаем отрицательные числа в положительные
{
    num = num * -1;
}

int num_test = num / 100; //проверка на разрядность меньше трёх
// Console.WriteLine(num_test);

if (num_test <= 0)
{
    Console.WriteLine($"The number {num} has no third digit");
}
else
{
    while (num >= 1000) //приведение числа к трёхзначному
    {
        num = num / 10;
    }
    //Console.WriteLine($"The digits {num} ");
    num = num % 10;
    Console.WriteLine($"{num} is the third digit on the left in the number");
}