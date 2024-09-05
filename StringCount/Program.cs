namespace StringCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra");
            string palavra = Console.ReadLine();

            char letraMin = 'a', letraMa = 'A';
           
            int count = 0;

            foreach (char caractere in palavra)
            {
                if (caractere == letraMin || caractere == letraMa)
                {
                    count++;
                } 

            }

            if (count == 0) { Console.WriteLine("A palavra não possui a letra 'A'. "); }

            else
            {
                Console.WriteLine($"A letra 'A' aparece {count} vezes.");
            }
        }
    }
}
