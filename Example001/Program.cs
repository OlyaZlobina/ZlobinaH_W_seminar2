// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write(" Input three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
void secondNumber()
{   int num3 = num / 10 % 10;
    Console.WriteLine(num + " -> " + num3);
}
secondNumber();
