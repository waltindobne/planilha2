using System.Diagnostics;

class Program
{
    static void Main()
    {
        double i = 1.25;
        i = i/100;
        double i2 = 1+i;
        double c = 3800;
        double n = 0;
        Console.WriteLine("os valores resultantes são:");

        while (n<6)
        {   n++; 
            double resulti = Math.Pow(i2,n);
            double m = c*resulti;
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"mes: {n}");
            Console.WriteLine($"montante: {m:C}");
            Console.WriteLine($"rendimento: {m-c:C}");
        }
    }
}