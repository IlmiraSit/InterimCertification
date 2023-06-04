// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

int firstNum = GetUserNumber("Enter first number: ", "Input error!");
int secondNum = GetUserNumber("Enter second number: ", "Input error!");

SumFromMToN(firstNum, secondNum);

void SumFromMToN(int firstNum, int secondNum)
{
    Console.Write(SumNum(firstNum - 1, secondNum));
}

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

int SumNum(int num1, int num2)
{
    int res = num1;
    if (num1 == num2)
        return 0;
    else
    {
        num1++;
        res = num1 + SumNum(num1, num2);
        return res;
    }
}