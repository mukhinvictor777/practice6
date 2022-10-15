int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите целое число, вы вввели {userLine}"); else break;
    }
    return result;
}

void printArray(int[] incomingArray)
{
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }       
    }
    Console.WriteLine();
}

int [] getIntegerArrayFromUser()
{
    int userArrayLenght = getNumberFromUser ("Какое количество целых чисел Вы хотите ввести?: ");
    int [] userArray = new int[userArrayLenght];
    for (int i = 0; i < userArrayLenght; i++)
    {
        userArray[i] = getNumberFromUser ($"Введите {i+1} число: ");
    }
    Console.WriteLine("Вы ввели след набор чисел:");
    printArray(userArray);
    return userArray;
}

int countOfPositiveNumbers(int [] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int [] userArray = getIntegerArrayFromUser();
int countOfPositive = countOfPositiveNumbers(userArray);
Console.WriteLine($"Количество положительных чисел в заданом массиве равно {countOfPositive}");