// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Summ(int a)
{
    int result = 0;
    int count=0;
    int n=0;
    for (int i = 0; a > 0 ; i++)
    {
        n=a%10;
        for (int j= 0; j < i; j++)
        {
            result = result + (a % 10);
            a = a/10;
        }     
    }
    return result;
}
int InputData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int number = InputData("Введите число А :");
int result = Summ(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {result}");