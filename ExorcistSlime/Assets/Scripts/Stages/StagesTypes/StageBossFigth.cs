using Assets.Scripts.MarkovChain;
using UnityEngine;

public class StageBossFigth : SceneController
{
    private GameObject[] enemyGenerationPoints;
    private GameObject bossGenerationPoint;
    private MarkovEnemyGeneration enemyTypeGenerator;

    public override void Awake()
    {
        base.Awake();
        enemyGenerationPoints = GameObject.FindGameObjectsWithTag("EnemyGenerationPoint");
        enemiesOnStage = enemyGenerationPoints.Length;

        foreach (GameObject generationPoint in enemyGenerationPoints)
        {
            GenerateEnemy(generationPoint);
        }

        bossGenerationPoint = GameObject.FindGameObjectWithTag("BossGenerationPoint");
        if(bossGenerationPoint != null)
        {
            GenerateBoss(bossGenerationPoint);
            ++enemiesOnStage;
        }
    }

    /// <summary>
    /// Method that scans if there are enemies on the stage and show won screen
    /// </summary>
    public override void Update()
    {
        if (enemiesOnStage <= 0)
        {
            ShowGameWonScene();
        }
    }

    public override void Start()
    {
        base.Start();
    }

}
