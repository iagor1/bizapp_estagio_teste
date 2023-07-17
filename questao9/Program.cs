namespace questao9teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculaIdade();
        }
        static void CalculaIdade()
        {
            Console.WriteLine("Digite o ano do seu nascimento : ");
            int data = int.Parse(Console.ReadLine());
            var data_atual = DateTime.Now.Year;
            var calc = data_atual - data;
            Console.WriteLine(calc);
        }
    }
}