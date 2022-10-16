// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

int InputUserNumber(int X)
{
    Console.Write("Введите число количества элементов массива: ");
    X = int.Parse(Console.ReadLine() ?? "");
    return X;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите следующий элемент массива: ");
        collection[index] = int.Parse(Console.ReadLine() ?? "");
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length - 1)
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
    if (index == length - 1)
        Console.WriteLine(collection[index]);
}

Console.Clear();
int X = 0;
int A = InputUserNumber(X);
int[] array = new int[A];
FillArray(array);
PrintArray(array);
