using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    public interface IAgent
    {
        public double getMedia(List<double> listOfNumbers);
        public string getStaircase(int number);
    }
}
