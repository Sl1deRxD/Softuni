namespace _2.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0, reminder;

            while (num > 0)
            {
                reminder = num % 10;
                sum = sum + reminder;
                num = num / 10;
            }
            Console.WriteLine(sum);

        }

    }
}
