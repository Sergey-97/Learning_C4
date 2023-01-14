/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.WriteLine("введите число A");
    Console.ForegroundColor = ConsoleColor. DarkCyan;
    int a = int.Parse(Console.ReadLine()!);
    Console.ResetColor ();
    
Console.WriteLine("введите число B");
    Console.ForegroundColor = ConsoleColor. DarkYellow;
    int b = int.Parse(Console.ReadLine()!);
    Console.ResetColor ();
int stepen = a;

int stepen1 = Auto ();
int Auto()
{
   for (int i = 1; i < b; i++)
     {
      stepen = stepen * a;
     }  
  Console.ForegroundColor = ConsoleColor. DarkGreen;
  Console.WriteLine($"{a} в степени {b} равно: " + stepen);
  Console.ResetColor(); 
return stepen;
}
