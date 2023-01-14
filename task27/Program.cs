// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = ReadInt("Введите число: ");
int len = NumberLen(num);
SumNumbers(num, len);
int ReadInt(string message)

{
    Console.ForegroundColor = ConsoleColor. DarkCyan;
    Console.Write(message);
    Console.ResetColor ();
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
     Console.ForegroundColor = ConsoleColor. DarkGreen;
    Console.Write($"сумма  цифр в чиселе {num} = "+ sum);
    Console.ResetColor(); 
}

