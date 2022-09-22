// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите день недели от 1 до 7: ");
int dayweek = Convert.ToInt32(Console.ReadLine());

void Weekend (int dayweek)
{
    if (dayweek == 6 || dayweek == 7)
    {
        Console.WriteLine("Это выходной день! ");
    }
    else 
    {
        Console.WriteLine("Это не выходной день! ");
    }
       
}
Weekend(dayweek);