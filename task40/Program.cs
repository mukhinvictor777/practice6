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

void checkPossibleTriangle(double A, double B, double C)
{
    if (
            (A + B <= C)||
            (A + C <= B)||
            (B + C <= A)
       )
        {
            Console.WriteLine($"Треугольник со сторонами {A} {B} {C} не может существовать");
        }
    else
        {
            Console.WriteLine($"Треугольник со сторонами {A} {B} {C} существует");
        }
}

double userNumberA = getDoubleNumberFromUser ("Введите длину первой стороны треугольника: ");
double userNumberB = getDoubleNumberFromUser ("Введите длину второй стороны треугольника: ");
double userNumberC = getDoubleNumberFromUser ("Введите длину третьей стороны треугольника: ");
checkPossibleTriangle(userNumberA, userNumberB, userNumberC);