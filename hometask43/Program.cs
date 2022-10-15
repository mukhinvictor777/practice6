double getDoubleNumberFromUser(string userInformation)
{
    double  result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите число, вы вввели {userLine}"); else break;
    }
    return result;
}

double intersectionX (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);   
    return x;
}

double intersectionY (double k1, double b1, double x)
{   
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите значение b1 для уравнения (y = k1 * x + b1) ");
double userB1 = getDoubleNumberFromUser("b1 = ");
Console.Write("Введите значение k1 для уравнения (y = k1 * x + b1) ");
double userK1 = getDoubleNumberFromUser("k1 = ");
Console.Write("Введите значение b2 для уравнения (y = k2 * x + b2) ");
double userB2 = getDoubleNumberFromUser("b2 = ");
Console.Write("Введите значение k2 для уравнения (y = k2 * x + b2) ");
double userK2 = getDoubleNumberFromUser("k2 = ");
Console.WriteLine("Для прямых заданных уравнениями:");
Console.WriteLine($"y = {userK1} * x + {userB1}");
Console.WriteLine($"y = {userK2} * x + {userB2}");
double coordinateX = intersectionX(userB1, userK1, userB2, userK2);
double coordinateY = intersectionY(userK1, userB1, coordinateX);
Console.WriteLine($"Пересечением является точка A [{coordinateX};{coordinateY}]");