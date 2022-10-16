// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

int InputUserNumber(string msg, string errorMsg)
{
    while (true)
    {
        Console.Write(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMsg);
    }
}

int SumNumbers(int num)

{
    int count = 0;
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
        count++;
    }
    return sum;
}

Console.Clear();
int num = InputUserNumber("Введите число: ", "Ошибка ввода!");
int sum = SumNumbers(num);
Console.WriteLine($"{num} -> {sum}");