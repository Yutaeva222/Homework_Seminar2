// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number) 
{
    int Dec = number / 10 % 10;  
    return Dec;
}
int secondDig = SecondDigit(number);
Console.WriteLine("Вторая цифра этого числа " + secondDig);


