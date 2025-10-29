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
        Console.Write("Nhap ban kinh hinh tron: ");
        double r = double.Parse(Console.ReadLine());
        double C, S;
        TinhHinhTron(r, out C, out S);
        Console.WriteLine($"Chu vi: {C}");
        Console.WriteLine($"Dien tich: {S}");
    }
}