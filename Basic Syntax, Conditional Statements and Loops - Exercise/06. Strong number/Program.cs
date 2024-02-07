int number = int.Parse (Console.ReadLine ());

int result = 1;

for (int i = number; i > 0; i--)
{
    result *= i;
}
Console.WriteLine(result);


