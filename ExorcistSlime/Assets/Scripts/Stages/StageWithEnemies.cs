using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StageWithEnemies : SceneController
{
    private EnemyGenerationPoint[] enemyGenerationPoints;
    public GameObject enemyPrefab;

    public override void Awake()
    {
        base.Awake();
        enemyGenerationPoints = (EnemyGenerationPoint[])Object.FindObjectsOfType<EnemyGenerationPoint>();
        foreach (EnemyGenerationPoint generationPoint in enemyGenerationPoints)
        {
            Instantiate(enemyPrefab, generationPoint.transform.position, generationPoint.transform.rotation);
        }
    }
    
}
