namespace ATM
{
    public class Program
    {
        public static decimal Balance;
        static void Main(string[] args)
        {
            Userinterface();
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }
        public static decimal Withdraw(decimal number)
        {
            if (number <= 0)
            {
                Console.WriteLine("number should bigger zero!");
            }

            if (number > Balance)
            {
                Console.WriteLine("Your balance is less than number required");
            }

            Balance = Balance - number;

            return Balance;
        }

        public static decimal Deposit(decimal number)
        {

            if (number <= 0)
            {
                Console.WriteLine("You should enter number bigger than zero!");
                return Balance;
            }
            Balance = Balance + number;

            return Balance;
        }

        public static void Userinterface()
        {
            string Input;
            do
            {

                Console.WriteLine("What is the operation that you want to perform?");
                Console.WriteLine("A View Balance");
                Console.WriteLine("B Withdraw");
                Console.WriteLine("C Deposit");
                Console.WriteLine("D Exit");

                Input = Console.ReadLine();



                switch (Input)
                {
                    case "A":
                        Console.WriteLine($"Your Balance = {ViewBalance()}");
                        break;
                    case "B":
                        Console.WriteLine("What is number you need withdraw:");
                        decimal drawNum;
                        drawNum = Convert.ToDecimal(Console.ReadLine());

                        Balance = Withdraw(drawNum);

                        break;
                    case "C":
                        decimal depNum;
                        Console.WriteLine("What is number you need Deposit:");
                        depNum = Convert.ToDecimal(Console.ReadLine());


                        Balance = Deposit(depNum);

                        break;
                    case "D":
                        Console.WriteLine("Exiting from application");

                        break;

                    default:
                        Console.WriteLine("Please choose correct option!");
                        break;
                }

            } while (Input != "D");

        }


    }
}