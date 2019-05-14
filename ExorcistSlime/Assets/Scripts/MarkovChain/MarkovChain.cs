using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MarkovChain
{
    public class MarkovChain
    {
        public int stages;
        public double[,] markovProbabilities;

        public int getNextState(int currentStateIndex)
        {
            Random randomNumber = new Random();

            double randomValue = randomNumber.NextDouble();

            double sum = 0;

            for(int columnIterator = 0; columnIterator < stages; columnIterator++)
            {
                sum += markovProbabilities[currentStateIndex, columnIterator];
                if (randomValue <= sum)
                    return columnIterator;
            }
            return -1;
        }
    }
}
