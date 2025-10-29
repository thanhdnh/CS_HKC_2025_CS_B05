using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static double TinhTong(double a, double b)
    {
        double tong = a + b;
        return tong;
    }
    static uint TinhTongN(uint n)
    {
        uint tong = 0;
        for (uint i = 1; i <= n; i++)
            tong = tong + i;
        return tong;
    }
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }
    static void Swap(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Inside: {a}, {b}");
    }
    static void TinhHinhTron(double r, out double C,
                                           out double S)
    {
        C = 2*Math.PI*r;
        S = Math.PI*r*r;
    }
    private static void Main(string[] args)
    {
        /*
        double x, y;
        Console.Write("Nhap 2 so x, y: ");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        Console.WriteLine($"{x}+{y}={TinhTong(x, y)}");
        */
        /*
        uint n;
        Console.Write("Nhap n: ");
        n = uint.Parse(Console.ReadLine());
        Console.WriteLine($"1+2+...+{n}={TinhTongN(n)}");
        */
        /*
        double x = 4, y = 5;
        Console.WriteLine($"x={x}, y={y}");
        Swap(ref x, ref y);
        Console.WriteLine($"x={x}, y={y}");
        */
        /*
        Console.Write("Nhap ban kinh hinh tron: ");
        double r = double.Parse(Console.ReadLine());
        double C, S;
        TinhHinhTron(r, out C, out S);
        Console.WriteLine($"Chu vi: {C}");
        Console.WriteLine($"Dien tich: {S}");
        */

    }
    static void Solve2OrderEqn(double a, double b, double c)
    {
        /*Console.WriteLine("Nhap so a,b,c:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());*/
        double delta = b * b - 4 * a * c;

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm ");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm ");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phương trình 1 nghiệm " + x);
            }
        }
        if (delta < 0)
            Console.WriteLine("Phương trình vô nghiệm");
        if (delta == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine($"Phương trình có nghiệp kép x1 = x2 = {x}");
        }
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phương trình có 2 nghiệm Phân biệt x1 = {x1},x2={x2}");
        }    
    }
}