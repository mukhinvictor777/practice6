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

int[] generateArray(int lenght, int start, int end)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void printArray(int[] incomingArray, string name)
{
    Console.WriteLine($"---------------{name}---------------");
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }       
    }
    Console.Write("]");
}

int[] reverseArray(int[] inputArray)
{
        int[] reversedArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        reversedArray[i] = inputArray[inputArray.Length - i - 1];
    }
    return reversedArray;
}

int arrayLenght = getNumberFromUser ("Введите длину массива целых чисел: ");
int startPoint = getNumberFromUser ("Задайте минимально возможное значение в массиве: ");
int endPoint = getNumberFromUser ("Задайте максимально возможное значение в массиве: ");
int [] randomArray = generateArray(arrayLenght, startPoint, endPoint);
printArray(randomArray, "Прямой");
int [] reversedArray = reverseArray(randomArray);
printArray(reversedArray, "Обратный");