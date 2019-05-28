using UnityEngine;

public class StageWithEnemies : SceneController
{
    private EnemyGenerationPoint[] enemyGenerationPoints;
    public GameObject nextStageDoor;
    public GameObject enemyPrefab;

    public override void Awake()
    {
        base.Awake();
        enemyGenerationPoints = FindObjectsOfType<EnemyGenerationPoint>();
        enemiesOnStage = enemyGenerationPoints.Length;
        foreach (EnemyGenerationPoint generationPoint in enemyGenerationPoints)
        {
            Instantiate(enemyPrefab, generationPoint.transform.position, generationPoint.transform.rotation);
        }
    }

    /// <summary>
    /// Method that scans if there are enemies on the stage and open the next stage door
    /// </summary>
    public override void Update()
    {
        if(enemiesOnStage <= 0)
        {
            OpenNextStageDoor();
        }
    }

    /// <summary>
    /// Method to destroy the door and let the player enter the next stage
    /// </summary>
    private void OpenNextStageDoor()
    {
        NextStageDoor door = FindObjectOfType<NextStageDoor>();
        if(door != null)
        {
            door.DestroyDoor();
        }
        playerCanNextStage = true;
    }
}
