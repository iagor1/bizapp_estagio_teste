namespace questao11teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string texto = Console.ReadLine();
            Console.Write("Digite um Caracter para ser buscado na frase: ");
            string c = Console.ReadLine();
            VerificaFrase(texto,c);
        }

        static void VerificaFrase(string frase, string caracter)
        {
  
            if (frase.Contains(caracter))
            {
                var p = frase.IndexOf(caracter);
                Console.WriteLine("o caracter "+ caracter +" está na posição : " + p);
            }
            else
            {
                Console.WriteLine("Não existe o elemento buscado");
            }
        }
    }
}