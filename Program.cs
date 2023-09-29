class Program
{
    static void Main()
    {
        Console.WriteLine("digite o valor esperado: ");
        double m = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o a taxa do juros aplicado: ");
        double i = double.Parse(Console.ReadLine());
        i = i/100;
        Console.WriteLine("digite o periodo de duração em meses: ");
        double n = double.Parse(Console.ReadLine());
        double i2 = 1+i;
        
        Console.Write("o capital necessario é: ");
        double resulti = Math.Pow(i2,n);
        double c = m/resulti;

        Console.WriteLine($"{c:C}");
    }
}