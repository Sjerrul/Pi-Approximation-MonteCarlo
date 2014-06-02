using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.MonteCarloPi.App
{
    public class MonteCarloApproximator
    {
        private Random _random = new Random();

        public MonteCarloApproximator()
        {

        }

        /// <summary>
        /// Get's pi as determined by a Monte Carlo Approximation. The larger the number of iterations, the more time it takes but the more precise the result
        /// </summary>
        /// <param name="numberOfIterations">The number of iterations used in the approximation</param>
        /// <returns></returns>
        public double GetPi(int numberOfIterations)
        {
            Func<double, double, bool> PiLambda = (x, y) => { return Math.Pow(x, 2) + Math.Pow(y, 2) <= 1; };
          
            int hits = 0;
            int iteration = 0;
            while (iteration != numberOfIterations)
            {
                double x = GetRandomBetween(-1, 1);
                double y = GetRandomBetween(-1, 1);

                if (PiLambda.Invoke(x, y))
                {
                    hits++;
                }

                iteration++;
            }

            double rho = ((double)hits/numberOfIterations);
            double pi = rho * 4;

            return pi;
        }

        public double GetRandomBetween(double low, double high)
        {
            double offset = low - high;
            return (_random.NextDouble() * high) + low;
        }
    }
}
