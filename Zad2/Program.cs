//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет (645 -> 5,  78 -> третьей цифры нет, 32679 -> 6). 

Console.WriteLine("Введите любое число ");
string number1 = Console.ReadLine();
int length = number1.Length;
if(length >= 3)
{ 
int one = Int32.Parse(number1);
Console.Clear();
Console.WriteLine("Третяя цифра — " + number1[2]);
}
else
{
Console.WriteLine("Третей цифры нет, попробуйте ввести другое число"); 
}
 