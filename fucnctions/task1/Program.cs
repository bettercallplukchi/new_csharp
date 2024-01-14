double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}
double res = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(res);