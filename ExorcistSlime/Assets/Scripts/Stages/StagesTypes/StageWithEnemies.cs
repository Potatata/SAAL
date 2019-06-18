using Assets.Scripts.MarkovChain;
using UnityEngine;

public class StageWithEnemies : SceneController
{
    private GameObject[] enemyGenerationPoints;
    public GameObject nextStageDoor;

    public override void Awake()
    {
        base.Awake();
        enemyGenerationPoints = GameObject.FindGameObjectsWithTag("EnemyGenerationPoint");
        enemiesOnStage = enemyGenerationPoints.Length;
        
        foreach (GameObject generationPoint in enemyGenerationPoints)
        {
            GenerateEnemy(generationPoint);
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

    public override void Start()
    {
        base.Start();
        FindObjectOfType<AudioManager>().PlaySecondLevelSong();
    }
}
