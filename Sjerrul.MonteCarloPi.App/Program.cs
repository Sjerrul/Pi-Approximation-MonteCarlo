using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.MonteCarloPi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            MonteCarloApproximator approximator = new MonteCarloApproximator();

            Console.WriteLine(String.Format("Pi = {0} ({1} iterations)", approximator.GetPi(1000), 1000));
            Console.WriteLine(String.Format("Pi = {0} ({1} iterations)", approximator.GetPi(10000), 10000));
            Console.WriteLine(String.Format("Pi = {0} ({1} iterations)", approximator.GetPi(100000), 100000));
            Console.WriteLine(String.Format("Pi = {0} ({1} iterations)", approximator.GetPi(1000000), 1000000));

            Console.ReadKey();

        }
    }
}
