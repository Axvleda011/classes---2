namespace classes___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            try
            {
                user.FirstName = "Giorgi";
                user.LastName = "Beridze";
                user.Age = 25;
                user.Email = "giorgi@gmail.com";
                user.Password = "Giorgi123";
                user.PhoneNumber = "599123456";
                user.Username = "giorgi25";
                user.PersonalNumber = "01001011111";
                user.Balance = 1500;
                user.BirthDate = new DateTime(2001, 5, 10);

                Console.WriteLine("User created successfully!");
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
