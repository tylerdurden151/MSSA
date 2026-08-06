/*
 * 2. Write a C# Sharp program that takes userid and password as input (type string). 
 * After 3 wrong attempts, user will be rejected.
 */

UserAuthentication auth = new UserAuthentication();
auth.Run();

class UserAuthentication
{
    private const string CorrectUserId = "admin";
    private const string CorrectPassword = "password123";
    private const int MaxAttempts = 3;
    public void Run()
    {
        int attempts = 0;
        while (attempts < MaxAttempts)
        {
            Console.Write("Enter User ID: ");
            string userId = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            if (Authenticate(userId, password))
            {
                Console.WriteLine("Access granted.");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine($"Incorrect User ID or Password. Attempts left: {MaxAttempts - attempts}");
            }
        }
        Console.WriteLine("Access denied. Too many failed attempts.");
    }
    private bool Authenticate(string userId, string password)
    {
        return userId == CorrectUserId && password == CorrectPassword;
    }
}