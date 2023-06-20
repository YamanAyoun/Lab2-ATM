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
        [InlineData(50)]
        [InlineData(100)]
        public void TestWithdrawOperation(decimal withdrawNumber)
        {
            
            Program.Balance = 200;
           
            decimal newBalance = Program.Withdraw(withdrawNumber);

            Assert.Equal(200 - withdrawNumber, newBalance);
        }

        [Fact]
        public void WithdrawThrowException()
        {

            Program.Balance = 50;

            Assert.Throws<Exception>(() => Program.Withdraw(100));
        }

        [Theory]
        [InlineData(50)]
        [InlineData(100)]
        public void TestDepositOperation(decimal depositAmount)
        {

            Program.Balance = 200;

            decimal newBalance = Program.Deposit(depositAmount);

            Assert.Equal(200 + depositAmount, newBalance);
        }

        [Fact]
        public void DepositWhenNumberZeroOrNegative()
        {
            Program.Balance = 200;

            decimal newBalance = Program.Deposit(0);

            Assert.Equal(200, newBalance);
        }

        
    
}
}