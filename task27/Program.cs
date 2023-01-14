// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor. DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor ();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int getSumOfRange(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        int num = i % 10;
        i = i / 10;
        sum = sum + num;
    }
    return sum;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor. DarkGreen;
    Console.Write(data);
    Console.ResetColor(); 
}
int end = getUserData("Введите число");
int sum = getSumOfRange(1,end);
showData($"сумма  цифр в чиселе {end} = ", sum);