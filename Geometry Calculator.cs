string figureType = Console.ReadLine().ToLower();
double parameterOne = 0;
double parameterTwo = 0;

if (figureType == "triangle" || figureType == "rectangle")
{
    parameterOne = double.Parse(Console.ReadLine());
    parameterTwo = double.Parse(Console.ReadLine());
}

else
{
    parameterOne = double.Parse(Console.ReadLine());
}

PrintArea(parameterOne, parameterTwo, figureType);
static void PrintArea(double parameterOne, double parameterTwo, string figureType)
{
    double result = CalculateArea(parameterOne, parameterTwo, figureType);
    Console.WriteLine($"{result:f2}");
}

static double CalculateArea(double parameterOne, double parameterTwo, string figureType)
{
    double result = 0;

    if (figureType == "triangle" || figureType == "rectangle")
    {
        if (figureType == "triangle")
        {
            result = (parameterOne * parameterTwo) / 2;
        }
        else
        {
            result = parameterOne * parameterTwo;
        }
    }

    if (figureType == "square")
    {
        result = Math.Pow(parameterOne, 2);
    }

    else if (figureType == "circle")
    {
        result = Math.PI * Math.Pow(parameterOne, 2);
    }

    return result;
}