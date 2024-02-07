string username = Console.ReadLine();

char[] charArray = username.ToCharArray();
Array.Reverse(charArray);

string pass = new string(charArray);

int attempts = 4;

while (attempts > 0)
{
    attempts--;

    string typedPass = Console.ReadLine();

    if (typedPass == pass)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else
    {
        if (attempts == 0)
        {
            Console.WriteLine($"User {username} blocked!");
        }
        else
        {
            Console.WriteLine("Incorrect password. Try again.");
        }
    }
}
