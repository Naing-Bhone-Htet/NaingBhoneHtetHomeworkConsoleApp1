namespace NaingBhoneHtetHomeworkConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Email: ");
        string? email = Console.ReadLine();
        Console.WriteLine("Enter your Password: ");
        string? password = Console.ReadLine();

        if (string.IsNullOrEmpty(email) || (string.IsNullOrEmpty(password)))
        {
            Console.WriteLine("Login Fail Email and Password Cannot Be Empty");
        }
        else
        {
            Console.WriteLine("Login Successful");
        }

        Console.ReadLine();
    }
}
