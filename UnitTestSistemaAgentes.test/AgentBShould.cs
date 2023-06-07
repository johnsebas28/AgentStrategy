using SistemaAgentes.Core.Implementations;
using System.Text;
using Xunit;
namespace UnitTestSistemaAgentes.test
{
    public class AgentBShould
    {
        [Fact]
        public void ValidateMediaArmonica()
        {
            //Arrange
            var AgentB = new SistemaAgentes.Core.Implementations.AgentB();
            List<double> numbers = new List<double>() { 2, 3, 4, 5 };
            //Act
            var isValid = Math.Round( AgentB.GetMedia(numbers), 2);
            //Assert
            Assert.Equal(3.12, isValid);
        }
        [Fact]
        public void ValidateMediaforOneElement()
        {
            //Arrange
            var AgentB = new SistemaAgentes.Core.Implementations.AgentB();
            List<double> numbers = new List<double>() { 10 };
            //Act
            var isValid = AgentB.GetMedia(numbers);
            //Assert
            Assert.Equal(10, isValid);
        }

        [Fact]
        public void ValidateMediaforMultiplesElements()
        {
            //Arrange
            var AgentA = new SistemaAgentes.Core.Implementations.AgentA();
            List<double> numbers = new List<double>() { 3, 4, 3, 5, 4, 5 };
            //Act
            var isValid = AgentA.GetMedia(numbers);
            //Assert
            Assert.Equal(4, isValid);
        }

        [Fact]
        public void getStartfor4()
        {
            //Arrange
            var AgentB = new SistemaAgentes.Core.Implementations.AgentB();
            StringBuilder expected = new StringBuilder();
            expected.Append("####" + Environment.NewLine);
            expected.Append(" ###" + Environment.NewLine);
            expected.Append("  ##" + Environment.NewLine);
            expected.Append("   #");
            //Act
            var start = AgentB.GetStaircase(4);
            //Assert
            Assert.NotNull(start);
            Assert.Equal(expected.ToString(), start);
        }
    }
}
