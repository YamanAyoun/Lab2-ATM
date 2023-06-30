using ATM;

namespace AtmTest
{
    public class UnitTest1
    {

        [Fact]
        public void ReturnTheViewBalance()
        {
            decimal balance = 100;
            Program.Balance = balance;


            decimal newBalance = Program.ViewBalance();


            Assert.Equal(balance, newBalance);
        }



        [Theory]
        [InlineData(50)]
        [InlineData(100)]
        public void TestDepositOperation(decimal deposit)
        {

            Program.Balance = 200;

            decimal newBalance = Program.Deposit(deposit);

            Assert.Equal(200 + deposit, newBalance);
        }


        [Theory]
        [InlineData(-50)]
        public void DepositWhenNumberZeroOrNegative(decimal deposit)
        {

            Program.Balance = 100;

            decimal newBalance = Program.Deposit(deposit);

            Assert.Equal(100, newBalance);
        }

        [Fact]        
        
        public void TestWithdrawLessThanZero()
        {
            decimal withdrawNumber = -100;
            Program.Balance = 200;

            decimal newBalance = Program.Withdraw(withdrawNumber);

            Assert.Equal(200, newBalance);
        }

        [Fact]
        public void TestWithdraw()
        {
            decimal withdrawNumber = 50;
            Program.Balance = 200;

            decimal newBalance = Program.Withdraw(withdrawNumber);

            Assert.Equal(150, newBalance);
        }



    }
}