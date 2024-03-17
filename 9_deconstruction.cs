Console.WriteLine("Enter a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter c: ");
double c = Convert.ToDouble(Console.ReadLine());

Equation elements = new Equation(a, b, c);

Console.WriteLine("x1= " + elements.x1);
Console.WriteLine("x2= " + elements.x2);
class Equation
{
    public double x1, x2;
    public Equation(double a, double b, double c)
    {
        if ((b * b - 4 * a * c) >= 0)
        {
            x1 = (-b + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
            x2 = (-b - (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);

        }
        else
        {
            Console.WriteLine("D < 0");
            Environment.Exit(0);
        }
    }
}

