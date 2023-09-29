class Program
{
    static void Main()
    {
        Console.WriteLine("digite o valor do capital a ser aplicado");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o a taxa do juros aplicado ");
        double i = double.Parse(Console.ReadLine());
        i = i/100;
        Console.WriteLine("digite a quantidade de meses que deve ser pago o emprestimo");
        double n = double.Parse(Console.ReadLine());
        double i2 = 1+i;
        double resulti = Math.Pow(i2,n);
        double m = c*resulti;
        Console.Write("montante final: ");
        Console.WriteLine($"{m:C}");
    }
}