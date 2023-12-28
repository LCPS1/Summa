using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    public class AgentB : IAgent
    {
        public double getMedia(List<double> listOfNumbers)
        {
            double suma = 0;
            int n = listOfNumbers.Count;
            for (int i = 0; i < n; i++)
            {
                suma += 1 / listOfNumbers[i];
            }
            return n / suma;
        }

        public string getStaircase(int number)
        {
            if (number <= 0 || number >= 100)
            {
                throw new ArgumentException("The ladder size must be greater than 0 and less than 100.");
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                sb.Append(' ', i);
                sb.Append('#', number - i);
                sb.Append('\n');
            }
            return sb.ToString();

        }
    }
}
