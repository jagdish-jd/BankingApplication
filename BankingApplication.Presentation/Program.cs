namespace BankingApplication.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Username = null;
            string Password = null;

            Console.WriteLine("\n ::  Login Page ::");

            Console.WriteLine("Enter Username : ");
            Username = Console.ReadLine();

            if (Username != "")
            {

                Console.WriteLine("Enter Password : ");
                Password = Console.ReadLine();

                if(Username != "System" && Password == "manager")
                {
                    Console.WriteLine("\n\n :: Main Menu ::");
                }
                else
                {
                    Console.WriteLine("Invalid username");
                }
                // Console.WriteLine("\n\n :: Main Menu ::");

                Console.WriteLine("Customer");
                Console.WriteLine("Account");
                Console.WriteLine("Fund Transfer");
                Console.WriteLine("Fund Transfer statement");
                Console.WriteLine("Account Statement");
                Console.WriteLine("Exit");
            }

            Console.WriteLine("\n\n Thank you ! visit again.....");

            Console.ReadKey();
            
        }
    }
}
