using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    public class Agent
    {
        private IAgent? _agent;

        public void SetAgent (IAgent agent)
        {
            _agent = agent;
        }

        public double ShowMedia (List<double> listOfNumbers)
        {
            return _agent.getMedia(listOfNumbers);
        }

        public string ShowStairCase(int number)
        {
            return _agent.getStaircase(number);
        }
    }
}
