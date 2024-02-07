namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int sumOfAscii = 0;
            
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int asciiValue = (int)letter;
                sumOfAscii += asciiValue;

            }
            Console.WriteLine($"The sum equals: {sumOfAscii}");
        }
    }
}
