using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MarkovChain
{
    public class MarkovNextStage :  MarkovChain
    {
        public MarkovNextStage()
        {
            stages = 4;
            //markovProbabilities = new double[9, 9] {
            //    { 0.1, 0.9, 0, 0, 0, 0, 0, 0, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //    { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0 },
            //};
            markovProbabilities = new double[4, 4]
            {
                {0, 0.6, 0.3, 0.1 },
                {0, 0.5, 0.4, 0.1 },
                {0, 0.5, 0.3, 0.2 },
                {0, 0, 0, 1 }
            };
        }

    }
}
