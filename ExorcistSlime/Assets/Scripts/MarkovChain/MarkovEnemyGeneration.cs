using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MarkovChain
{
    public class MarkovEnemyGeneration : MarkovChain
    {
        public MarkovEnemyGeneration()
        {
            //States = types of enemies
            states = 4 ;

            //Probabilities order
            //EnemySimpleShootsAtPlayerController, EnemyDiagonalController, EnemySidesController, BossEnemyCirclesController
            markovProbabilities = new double[5, 4]
            {
                //First stage
                {0.7, 0.2, 0.1, 0},
                //Second stage
                {0.3, 0.5, 0.2, 0 },
                //Third Stage
                {0.1, 0.3, 0.6, 0 },
                //Fourth Stage
                {0, 0.3, 0.7, 0 },
                //Boss Figth
                {0, 0, 0, 1 }

            };
        }
    }
}

