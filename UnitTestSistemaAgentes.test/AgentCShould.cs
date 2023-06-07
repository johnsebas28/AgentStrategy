using System.Text;
using Xunit;

namespace UnitTestSistemaAgentes.test
{
    public class AgentCShould
    {
        [Fact]
        public void ValidateMediaPair()
        {
            //Arrange
            var AgentC = new SistemaAgentes.Core.Implementations.AgentC();
            List<double> numbers = new List<double>() { 2, 3, 4, 5 };
            //Act
             var isValid = AgentC.GetMedia(numbers);
           //Assert
            Assert.Equal(3.5, isValid);
        }
        [Fact]
        public void ValidateMediaforOdd()
        {
            //Arrange
            var AgentC = new SistemaAgentes.Core.Implementations.AgentC();
            List<double> numbers = new List<double>() { 2, 3, 4, 5, 6 };
            //Act
            var isValid = AgentC.GetMedia(numbers);
            //Assert
            Assert.Equal(4, isValid);
        }

       
        [Fact]
        public void getStartfor4()
        {
            //Arrange
            var AgentC = new SistemaAgentes.Core.Implementations.AgentC();
            StringBuilder expected = new StringBuilder();
            expected.Append("   ####   " + Environment.NewLine);
            expected.Append("  ######  " + Environment.NewLine);
            expected.Append(" ######## " + Environment.NewLine);
            expected.Append("##########" + Environment.NewLine);
            expected.Append(" ######## " + Environment.NewLine);
            expected.Append("  ######  " + Environment.NewLine);
            expected.Append("   ####   ");
            //Act
            var start = AgentC.GetStaircase(4);
            //Assert
            Assert.NotNull(start);
            Assert.Equal(expected.ToString(), start);
        }
    }
}
