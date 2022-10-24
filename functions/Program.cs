int getLenghtFromUser(string userInformation)
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

int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите целое, вы вввели {userLine}"); else break;
    }
    return result;
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

int [] RemovedElementInArray(int[] incomingArray, int index)
    {
        if (incomingArray.Length == index)
        {
            Array.Resize(ref incomingArray, incomingArray.Length - 1);
        }
        else
        {
            for (int i = index; i < incomingArray.Length - 1; i++)
            {
                incomingArray[i] = incomingArray[i+1];
            }
            Array.Resize(ref incomingArray, incomingArray.Length - 1);
        }
        return incomingArray;
    }

int [] addElementInArray(int[] incomingArray, int index, int element)
    {
        Array.Resize(ref incomingArray, incomingArray.Length + 1);
            for (int i = index; i < incomingArray.Length - 1; i++)
            {
                incomingArray[i+1] = incomingArray[i];
            }
            incomingArray[index] = element;
    return incomingArray;
    }


           

void checkPlentyFromRandomArray (int [] RandomArray, int plentySum)
{
    int [] plenty = new int [RandomArray.Length];
    int sumOfPositive = sumOfPositiveNumbers (RandomArray);
    int sumOfNegative = sumOfNegativeNumbers (RandomArray);
    int sum = sumOfNumbersInArray(RandomArray);
    int tempSum = sum;
    int buffer = 0;
    if (sum >= sumOfPositive)
    {
        Console.Write("В множистве ");
        printArray(RandomArray);
        Console.WriteLine($" не существует подмножества с суммой всех элементов равной {plentySum}");
    }
    else if (sum <= sumOfNegative)
        {
            Console.Write("В множистве ");
            printArray(RandomArray);
            Console.WriteLine($" не существует подмножества с суммой всех элементов равной {plentySum}");
        }
        else
        {
            if (plentySum == 0)
            {
                Console.Write("В множистве ");
                printArray(RandomArray);
                Console.WriteLine(" существует пустое подмножество, где нет ни одного элемента");
                Console.WriteLine();
            }
            if (sum == plentySum)
            {
                plenty = createCopyArray(RandomArray);
                Console.Write("В множистве ");
                printArray(RandomArray);
                Console.WriteLine($" существует подмножество с суммой всех элементов равной {plentySum}");
                printArray(plenty);
                Console.WriteLine();
            }
            


            for (int i = 0; i < RandomArray.Length; i++)
            {
                for (int j = 0; j < plenty.Length; j++)
                {
                    if (plentySum == tempSum - RandomArray[j]) // проверяем для каждого элемента масиива выполняется ли равенство, при котором, если убрать любой другой элемент,
                                                               // будет ли сумма оставшихся елементов равняться сумме искомого множества, другими словами, перебираем все
                                                               // возможные подмножества и проверяем есть ли среди них такие, сумма которых равна заданному числу. 
                                                               
                    {
                       buffer = RandomArray[j];
                       plenty = RemovedElementInArray(plenty, j);   //удаляем элемент из массива, без которого сумма оставшихся элементов в массиве равна заданному числу
                       Console.WriteLine($" существует подмножество с суммой всех элементов равной {plentySum}"); 
                       printArray(plenty); // выводим на экран множество, которое соответствует условию
                       Console.WriteLine();
                       plenty = addElementInArray(plenty, j, buffer); // возвращаем удаленный элемент на место для дальнешего поиска подходящих подмножеств в рамках заданного цикла.
                    }
                }
                // for (int k = 0; k < i; k++)
                //tempSum = tempSum - RandomArray[i];
            }
        }    
}

// int arrayLenght = getLenghtFromUser ("Введите длину массива целых чисел: ");
// int startPoint = getNumberFromUser ("Задайте минимально возможное значение в массиве: ");
// int endPoint = getNumberFromUser ("Задайте максимально возможное значение в массиве: ");
// int [] randomArray = getRandomArray(arrayLenght, startPoint, endPoint);
// printArray(randomArray);
// int plentySum = getNumberFromUser ("Введите сумму элементов для определения подмножества ");
// checkPlentyFromRandomArray(randomArray, plentySum);