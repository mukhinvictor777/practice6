int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0 || result < 1)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 1) Console.WriteLine($"Введите целое положительное число, вы вввели {userLine}"); else break;
    }
    return result;
}

int [] fibonachiArrayN (int N)
{
    int [] fibonachiArray = new int [N];
    fibonachiArray[0] = 0;
    if (N > 1)
    {
        fibonachiArray[1] = 1;
        for (int i = 2; i < fibonachiArray.Length; i++)
        {
            fibonachiArray[i] = fibonachiArray[i-1] + fibonachiArray[i-2];
        }
    }
    return fibonachiArray;
}

void printConvertedNumber(int [] convertedArray, int N)
{
    Console.Write($"Последовательность Фибоначи до числа {N} выглядит следующим образом ");
    for (int i = 0; i < convertedArray.Length; i++)
    {
        Console.Write($"{convertedArray[i]} ");
    }
    Console.WriteLine();
}

int number = getNumberFromUser($"Введите положительное число: ");
int [] fibonachi = fibonachiArrayN(number);
printConvertedNumber(fibonachi, number);