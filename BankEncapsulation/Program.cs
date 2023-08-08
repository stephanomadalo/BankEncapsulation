namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            
            account.Deposit(90);
            var bal = account.GetBalance();
            Console.WriteLine($"Your account balance is: {bal}");


        }
    }
}
