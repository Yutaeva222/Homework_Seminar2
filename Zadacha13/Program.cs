// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
 
Console.Clear(); 
Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
 
if (number < 0) 
{ 
    number = -number; 
} 
string numberstr = Convert.ToString(number); 
if (numberstr.Length > 2) 
{ 
  Console.WriteLine("Третья цифра  " + numberstr[2]); 
} 
else 
{ 
  Console.WriteLine("Третьей цифры нет"); 
}
