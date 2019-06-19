using Assets.Scripts.MarkovChain;
using UnityEngine;

public class StageBossFigth : SceneController
{
    private GameObject generationPoint;
    private MarkovEnemyGeneration enemyTypeGenerator;

    public override void Awake()
    {
        base.Awake();
        enemyTypeGenerator = new MarkovEnemyGeneration();
        generationPoint = GameObject.FindGameObjectWithTag("EnemyGenerationPoint");
        enemiesOnStage = 1;
        if (generationPoint != null)
        {
            GenerateEnemy(generationPoint);
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
        AudioManager.GetInstance().PlayBossSong();
    }

}
