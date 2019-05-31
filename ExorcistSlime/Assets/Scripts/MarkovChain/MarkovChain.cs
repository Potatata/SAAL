using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MarkovChain
{
    public class MarkovChain
    {
        public int states;
        public double[,] markovProbabilities;
        Random randomNumber = new Random();

        public int getNextState(int currentStageIndex)
        {
            double randomValue = randomNumber.NextDouble();

            double sum = 0;

            for(int columnIterator = 0; columnIterator < states; columnIterator++)
            {
                sum += markovProbabilities[currentStageIndex, columnIterator];
                if (randomValue <= sum)
                    return columnIterator;
            }
            return -1;
        }
    }
}
