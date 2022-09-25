// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else if(number > 7)
{
    Console.WriteLine("Неверное число");
}
else
{
    Console.WriteLine("Нет");
}