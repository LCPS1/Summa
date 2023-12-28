using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    public class AgentC : IAgent
    {
        public double getMedia(List<double> listOfNumbers)
        {
            listOfNumbers.Sort();
            int n = listOfNumbers.Count;
            if (n % 2 == 1)
            {
                return listOfNumbers[n / 2];
            }
            else
            {
                return (listOfNumbers[n / 2] + listOfNumbers[n / 2 - 1]) / 2;
            }
        }

        public string getStaircase(int number)
        {
            if (number <= 0 || number >= 100)
            {
                throw new ArgumentException("The ladder size must be greater than 0 and less than 100.");
            }

            StringBuilder sb = new StringBuilder();
            // Top half
            for (int i = 1, k = number, l = 2 * number - 1; i < number; i++, k--, l++)
            {
                for (int j = 0; j < 3 * number; j++)
                {
                    if (j >= k && j <= l)
                    {
                        sb.Append('#');
                    }
                    else
                    {
                        sb.Append(' '); 
                    }
                }
                sb.Append('\n');
            }
            // Bottom half
            for (int i = 0, k = 1, l = 3 * number - 2; i < number; i++, k++, l--)
            {
                for (int j = 0; j < 3 * number; j++)
                {
                    if (j >= k && j <= l)
                    {
                        sb.Append('#');
                    }
                    else
                    {
                        sb.Append(' ');
                    }
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
