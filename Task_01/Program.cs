// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B (без использования Math.Pow).
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Pow(int a, int b)
{    
     int result = 1;
     for (int i = 0; i < b; i++)
    {
      result = result * a;
    }
    return result;
}   
 int InputData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int numberA = InputData("Введите число А :");
int numberB = InputData("Введите число В :");
int result = Pow(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");