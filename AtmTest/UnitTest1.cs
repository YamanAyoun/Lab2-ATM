using ATM;

namespace AtmTest
{
    public class UnitTest1
    {

        [Fact]
        public void ReturnTheViewBalance()
        {
            Program.Balance = 100;

            decimal balance = Program.ViewBalance();

            Assert.Equal(100, balance);
        }

        [Theory]
        [InlineData(200, 200, 400)]


        public void TestDepositOperation(decimal deposit, decimal balance, decimal BalanceAfterDeposit)
        {
            Program.Balance = balance;

            decimal act = Program.Deposit(deposit);
            Assert.Equal(BalanceAfterDeposit, act);

        }

        [Theory]
        [InlineData(500, 200, 300)]


        public void TestWithdrawOperation(decimal balance, decimal Withdraw, decimal BalanceAfterWithdraw)
        {
            Program.Balance = balance;

            decimal act = Program.Withdraw(Withdraw);
            Assert.Equal(BalanceAfterWithdraw, act);

        }




    }
}