using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Extensions;
using FluentAssertions.Numeric;
using Suma;

namespace Suma.Tests
{
    public class SumaTests
    {
        private readonly Agent _agent;
        private readonly List<double> DataText = new List<double>() { 1, 2, 3, 6, 4, 5 };

        public SumaTests()
        {
            //SUT
            _agent = new Agent();
        }
        #region getMedia_Tests
        [Fact]
        public void SumaTest_Agent_ShowMediaAgentA_ReturnDouble()
        {
            //Arrange
            _agent.SetAgent(new AgentA());

            //ACT
            var result = _agent.ShowMedia(DataText);
            //ASSERT
            Assert.Equal(3.5, result, 2);
            Assert.IsType<double>(result);
        }

        [Fact]
        public void SumaTest_Agent_ShowMediaAgentB_ReturnDouble()
        {
            //Arrange
            _agent.SetAgent(new AgentB());
            //ACT
            var result = _agent.ShowMedia(DataText);
            //ASSERT
            Assert.Equal(2.448, result,2);
            Assert.IsType<double>(result);
        }

        [Fact]
        public void SumaTest_Agent_ShowMediaAgentC_ReturnDouble()
        {
            //Arrange
            _agent.SetAgent(new AgentC());
            //ACT
            var result = _agent.ShowMedia(DataText);
            //ASSERT
            Assert.Equal(3.5, result,2);
            Assert.IsType<double>(result);
        }

        #endregion

        #region getMedia_Tests

        [Fact]
        public void SumaTest_Agent_ShowStairCaseAgentA_ReturnString()
        {
            //Arrange
            int n = 5;
            _agent.SetAgent(new AgentA());
            //ACT
            var result = _agent.ShowStairCase(n);
            //ASSERT
            result.Should().NotBeNull();
            result.Should().BeOfType<string>();
            result.Should().Contain("#");
            result.Should().Contain(" ");
            result.Should().StartWith(" ");
        }

        [Fact]
        public void SumaTest_Agent_ShowStairCase_AgentB_ReturnString()
        {
            //Arrange
            int n = 3;
            _agent.SetAgent(new AgentB());
            //ACT
            var result = _agent.ShowStairCase(n);
            //ASSERT
            result.Should().NotBeNull();
            result.Should().BeOfType<string>();
            result.Should().Contain("#");
            result.Should().Contain(" ");
            result.Should().StartWith("#");
        }

        [Fact]
        public void SumaTest_Agent_ShowStairCase_AgentC_ReturnString()
        {
            //Arrange
            int n = 7;
            _agent.SetAgent(new AgentC());
            //ACT
            var result = _agent.ShowStairCase(n);
            //ASSERT
            result.Should().NotBeNull();
            result.Should().BeOfType<string>();
            result.Should().Contain("#");
            result.Should().Contain(" ");
            result.Should().StartWith(" ");
            result.Should().EndWith("");
        }
        #endregion
    }
}
