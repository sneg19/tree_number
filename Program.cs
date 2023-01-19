// Программа выводит третью цифру заданного числа
Console.Clear();
Console.WriteLine("Введите любое трехзначное число");
int number = int.Parse(Console.ReadLine()!);

int num_1 = number / 100;
int num_2 = num_1 % 10;

if (num_2 > 0) Console.WriteLine(num_2);
else Console.WriteLine("Третьего числа нет!");