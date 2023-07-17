using System.Runtime.InteropServices;

namespace Questao12teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma operação");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int operação = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os 2 números que serão usados na operação :");
            Int128 num1 = int.Parse(Console.ReadLine());
            Int128 num2 = int.Parse(Console.ReadLine());
            switch (operação)
            {
                case 1: Adicao(num1, num2);
                    break;
                case 2: Subtracao(num1,num2);
                    break;
                case 3: Multiplicacao(num1,num2);
                    break;
                case 4: Divisao(num1,num2);
                    break;

            }
            static void Adicao(Int128 num1, Int128 num2) 
            {
                Int128 calc = num1 + num2;
                Console.WriteLine("resultado : "+ calc);
            }
            static void Subtracao(Int128 num1, Int128 num2)
            {
                Int128 calc = num1 - num2;
                Console.WriteLine("resultado : " + calc);
            }
            static void Multiplicacao(Int128 num1, Int128 num2)
            {
                Int128 calc = num1 * num2;
                Console.WriteLine("resultado : " + calc);
            }
            static void Divisao(Int128 num1, Int128 num2)
            {
                Int128 calc = num1 / num2;
                Console.WriteLine("resultado : " + calc);
            }
        }
    }
}