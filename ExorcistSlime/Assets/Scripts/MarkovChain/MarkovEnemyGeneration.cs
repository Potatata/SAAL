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
            states = 3 ;

            //Probabilities order
            //EnemySimpleShootsAtPlayerController, EnemyDiagonalController, EnemySidesController, BossEnemyCirclesController
            markovProbabilities = new double[5, 3]
            {
                //First stage
                {0.7, 0.2, 0.1},
                //Second stage
                {0.3, 0.5, 0.2},
                //Third Stage
                {0.1, 0.3, 0.6},
                //Fourth Stage
                {0, 0.3, 0.7},
                //Boss Fight
                {0.1, 0.8, 0.1}

            };
        }
    }
}

