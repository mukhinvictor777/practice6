int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0 || result < 1)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 1) Console.WriteLine($"Введите целое число больше нуля, вы вввели {userLine}"); else break;
    }
    return result;
}

void printArray(int[] incomingArray)
{
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

int [] getRandomArray(int arrayLenght, int startPoint, int endPoint)
{
    int [] randomArray = new int [arrayLenght];
    for (int i = 0; i < arrayLenght; i++)
    {
        randomArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return randomArray;
}

int [] createCopyArray(int[] incomingArray)
{
    int [] copiedArray = new int [incomingArray.Length];
    for (int i = 0; i < copiedArray.Length; i++)
    {
        copiedArray[i] = incomingArray[i];
    }
    return copiedArray;
}  

int arrayLenght = getNumberFromUser ("Введите длину массива целых чисел: ");
int startPoint = getNumberFromUser ("Задайте минимально возможное значение в массиве: ");
int endPoint = getNumberFromUser ("Задайте максимально возможное значение в массиве: ");
int [] randomArray = getRandomArray(arrayLenght, startPoint, endPoint);
printArray(randomArray);
Console.WriteLine();
Console.WriteLine("Копия массива:");

int [] resultArray = createCopyArray (randomArray);
printArray(resultArray);