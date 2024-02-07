namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());

           for (int i = firstN; i <= secondN; i++)
            {
                char asciiChar = Convert.ToChar(i);
                Console.Write($"{asciiChar} ");
            }
        }
    }
}
