namespace _1.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            var firtSolution = num1 + num2;
            var secondSolution = firtSolution / num3;
            var finalSolution = secondSolution * num4;

            Console.WriteLine(finalSolution);
        }
    }

}
