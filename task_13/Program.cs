// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string number = Convert.ToString(Console.ReadLine());

int[] array = new int[number.Length];
int i;

for(i = 0; i < number.Length; i++)
{
    array[i] = Convert.ToInt32(number[i].ToString());
}

if(number.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
    Console.WriteLine(array[2]);