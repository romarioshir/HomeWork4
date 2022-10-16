// Напишите программу, которая принимает на вход два числа (A и B)
// и возводит А в натуральную степень В

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

Console.Clear();
int A = InputUserNumber("Введите число: ", "Ошибка ввода!");
int B = InputUserNumber("Введите степень: ", "Ошибка ввода!");

Console.WriteLine(Math.Pow(A, B));