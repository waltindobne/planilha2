using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {   
        Console.WriteLine("qual o capital aplicado");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("qual a taxa aplicada");
        double i = double.Parse(Console.ReadLine());
        i = i/100;
        double i2 = 1+i;
        
        Console.WriteLine("digite por quantos meses deseja executar essa aplicação");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("os valores resultantes são:");

        int a=0;
        if (a<n)
        {   a++; 
            double resulti = Math.Pow(i2,n);
            double m = c*resulti;
            Console.WriteLine($"montante: {m:C}");
            Console.WriteLine("deseja retirar algun valor?(favor prencher com sim ou não)");
            string retirada = Console.ReadLine();
            string s = "sim";
            string na = "não";
            if (retirada==s)
            {
                Console.WriteLine("qual o valor");
                double r = double.Parse(Console.ReadLine());
                m = m-r;
                Console.WriteLine($"montante restante{m:C}");
            }
            if (retirada==na)
            {
                Console.WriteLine("sua operação foi encerrada");
            }
        }
    }
}
