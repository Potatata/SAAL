using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MarkovChain
{
    public class MarkovNextStage : MarkovChain
    {
        public MarkovNextStage()
        {
            //State = Total of stages
            states = 5;

            //Stage 1 (Empty), Stage 2, Stage 3, Stage 4 (Boss Stage)
            markovProbabilities = new double[5, 5]
            {
                //Stage 1
                {0, 1, 0, 0, 0 },
                //Stage 2
                {0, 0.6, 0.4, 0, 0 },
                //Stage 3
                {0, 0, 0.4, 0.6, 0 },
                //Stage 4
                {0, 0, 0.3, 0.1, 0.6 },
                //BossFight
                {0, 0, 0, 0, 1 }
            };
        }

    }
}
