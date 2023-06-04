// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.Clear();

int n = GetUserNumber("Enter number N: ", "Error!");
int count = 1;
PrintNaturaNum(n, count);

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

void PrintNaturaNum(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        PrintNaturaNum(n, count + 1);
        Console.Write(count + " ");
    }
}