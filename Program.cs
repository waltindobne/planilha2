class Program
{
    static void Main()
    {
        Console.WriteLine("digite o valor do capital a ser aplicado");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o a taxa do juros aplicado )");
        double i = double.Parse(Console.ReadLine());
        i = i/100;
        Console.WriteLine("digite a quatidade de meses que deve ser pago o emprestimo");
        double n = double.Parse(Console.ReadLine());
        double i2 = 1+i;
        
        Console.Write("o montante final é: ");
        double resulti = Math.Pow(i2,n);
        double m = c*resulti;

        Console.WriteLine($"{m:C}");
    }
}