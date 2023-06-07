using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace UnitTestSistemaAgentes.test
{
    public class AgentAShould
    {
        [Fact]
        public void ValidateMedia5()
        {
            //Arrange
            var AgentA = new SistemaAgentes.Core.Implementations.AgentA();
            List<double> numbers = new List<double>() { 5, 5, 5, 5 };
            //Act
            var isValid = AgentA.GetMedia(numbers);
            //Assert
            Assert.Equal(5, isValid);
        }
        [Fact]
        public void ValidateMediaforOneElement()
        {
            //Arrange
            var AgentA = new SistemaAgentes.Core.Implementations.AgentA();
            List<double> numbers = new List<double>() { 10 };
            //Act
            var isValid = AgentA.GetMedia(numbers);
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
            var AgentA = new SistemaAgentes.Core.Implementations.AgentA();
            StringBuilder expected = new StringBuilder();
            expected.Append("   #" + Environment.NewLine);
            expected.Append("  ##" + Environment.NewLine);
            expected.Append(" ###" + Environment.NewLine);
            expected.Append("####" + Environment.NewLine);
            //Act
            var start = AgentA.GetStaircase(4);
            //Assert
            Assert.NotNull(start);
            Assert.Equal(expected.ToString(), start);
        }
    }
}

