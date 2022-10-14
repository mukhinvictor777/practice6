int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0 || result < 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0" || result < 0) Console.WriteLine($"Введите целое положительное число, вы вввели {userLine}"); else break;
    }
    return result;
}

int [] convertDecimalNumberToBinaryNumber (int decimalNumber)
{
    int countOfDigit = 1;
    int bufferNumber = decimalNumber;
    while (bufferNumber / 2 > 0)
    {
        countOfDigit++;
        bufferNumber /= 2;
    }
    int [] convertedArray = new int[countOfDigit];
    for (int i = 0; i < convertedArray.Length; i++)
    {
        convertedArray[countOfDigit-i-1] = decimalNumber % 2;
        decimalNumber /= 2;
    }
    return convertedArray;
}

void printConvertedNumber(int [] convertedArray, int numberInTen)
{
    Console.Write($"Число {numberInTen} в десятичной системе счисления равно ");
    for (int i = 0; i < convertedArray.Length; i++)
    {
        Console.Write(convertedArray[i]);
    }
    Console.Write(" в двоичной системе счисления");
}

int numberInTen = getNumberFromUser($"Введите положительное число: ");
int [] convertedArray = convertDecimalNumberToBinaryNumber(numberInTen);
printConvertedNumber(convertedArray, numberInTen);