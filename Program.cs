namespace QueteDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShowMoney showMoney = moneyInEuros;
            Console.WriteLine(showMoney(45.54));

            showMoney = moneyInDollars;
            Console.WriteLine(showMoney(45.54));
        }

        public delegate string ShowMoney(double amount);

        public static string moneyInEuros(double amount)
        {
            string resString = "€" + amount;
            return resString;
        }

        public static string moneyInDollars(double amount)
        {
            string resString = "$" + amount;
            return resString;
        }

    }
}
