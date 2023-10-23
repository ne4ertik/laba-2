double s = 1;
double i = 1;
do
{
    double a = 13 * i;
    if (a % 2 == 1) {
        s = s * a;
    }
    i++;
} while (i <= 7);
Console.WriteLine(s);