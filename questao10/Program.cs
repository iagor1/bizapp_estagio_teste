namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da venda : ");
            int venda = int.Parse(Console.ReadLine());
            if (venda <= 1000)
            {
                Calc1(venda);
            }
            else
            {
                Calc2(venda);
            }
        }
        static void Calc1(int valor) 
        {
            var p = (valor * 20) / 100;
            Console.WriteLine("O lucro foi de " + p);
        }
        static void Calc2(int valor)
        {
            var p = (valor * 15) / 100;
            Console.WriteLine("O lucro foi de " + p);
        }
    }
}