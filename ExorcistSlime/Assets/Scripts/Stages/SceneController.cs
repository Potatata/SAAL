using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Assets.Scripts.MarkovChain;

public abstract class SceneController : MonoBehaviour
{
    //Scenes config const
    protected const int scenesAfterFirtsStage = 1;
    protected const int numberOfScenes = 4;
    protected const int gameOverScene = 6;
    protected const int gameWonScene = 7;

    public GameObject playerPrefab;
    public GameObject playerRespawn;
    protected int currentScene;
    public UIComponent healthBar;
    public Canvas canvas;
    protected bool playerCanNextStage;
    protected int enemiesOnStage;

    //Enemy prefabs
    public GameObject enemyPrefabType0;
    public GameObject enemyPrefabType1;
    public GameObject enemyPrefabType2;
    public GameObject enemyPrefabDemonLord;

    //Enemy Markov generator
    private MarkovEnemyGeneration enemyTypeGenerator;



    public virtual void Awake()
    {
        //Search for the player respawn at the scene
        if (playerPrefab != null && playerRespawn != null)
        {
            Instantiate(playerPrefab, playerRespawn.transform.position, playerRespawn.transform.rotation);
        }

        currentScene = SceneManager.GetActiveScene().buildIndex;

        playerCanNextStage = false;


        enemyTypeGenerator = new MarkovEnemyGeneration();

    }

    public void Start()
    {
        canvas = GetComponentInChildren<Canvas>();
        canvas.worldCamera = Camera.main;
    }

    public virtual void Update(){}


    /// <summary>
    /// Method to decrease the enemies remaining on the stage
    /// </summary>
    public void EnemyDies()
    {
        enemiesOnStage--;
    }

    /// <summary>
    /// Method to load a scene
    /// </summary>
    /// <param name="sceneNumber">An int with the scene number to load</param>
    private void LoadScene(int sceneNumber)
    {
        if (playerCanNextStage)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }

    /// <summary>
    /// Loads a random next scene and unload the current scene
    /// </summary>
    public void LoadNextScene()
    {
        MarkovNextStage nextStageGenerator = new MarkovNextStage();
        System.Random randomNumber = new System.Random();
        int nextScene = nextStageGenerator.getNextState(currentScene - scenesAfterFirtsStage);
        LoadScene(nextScene + scenesAfterFirtsStage);
    }

    public void ShowGameOverScene()
    {
        SceneManager.LoadScene(gameOverScene);
    }

    public void ShowGameWonScene()
    {
        SceneManager.LoadScene(gameWonScene);
    }

    protected void GenerateEnemy(GameObject generationPoint)
    {
        int enemyType = enemyTypeGenerator.getNextState(currentScene - scenesAfterFirtsStage);
        switch (enemyType)
        {
            case 0:
                Instantiate(enemyPrefabType0, generationPoint.transform.position, generationPoint.transform.rotation);
                break;
            case 1:
                Instantiate(enemyPrefabType1, generationPoint.transform.position, generationPoint.transform.rotation);
                break;
            case 2:
                Instantiate(enemyPrefabType2, generationPoint.transform.position, generationPoint.transform.rotation);
                break;
            case 3:
                Instantiate(enemyPrefabDemonLord, generationPoint.transform.position, generationPoint.transform.rotation);
                break;
            default:
                break;
        }
    }
}
