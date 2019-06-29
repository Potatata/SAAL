using UnityEngine;
using Prime31;
using System.Collections;

public class PlayerController : CharacterController
{
    //Constants
    public const float SPEED = 16f;
    public const int SALT_PARTICLES = 16 ;
    public const float DASH_SPEED = SPEED*3;
    public const float DASH_TIME = 0.01f;
    public const int MANA_COMSUNPTION = 30;
    public const int MANA = 60;
    public const float RESTORING_TIME = 0.083f;
    public const float TAUNTING_TIME = 2.5f;

    // Movement configuration
    public int mana = MANA;

    //Fields
    private TopDownMovementController2D _controller;
	private Vector3 _velocity;
    public GameObject saltPrefab;
    public bool isDashing = false;
    public bool isRestoringMana = false;
    public bool isTaunting = false;
    UIComponent playerStaminaBar;
    public Animator anim;

    void Awake()
	{
        playerStaminaBar = GameObject.FindGameObjectWithTag("PlayerStaminaBar").GetComponent<UIComponentPlayerStaminaBar>();
        _controller = GetComponent<TopDownMovementController2D>();
        movementSpeed = SPEED;
    }

    IEnumerator MakeTrail()
    {
        isDashing = true;
        _controller.SetInvincibility(true);
        for (int i = 0; i < SALT_PARTICLES; i++)
        {
            LeaveTrail();
            yield return new WaitForSeconds(DASH_TIME);

        }
        movementSpeed = SPEED;
        isDashing = false;
        _controller.SetInvincibility(false);
    }

    private void LeaveTrail()
    {
        Instantiate(saltPrefab, this.transform.position, this.transform.rotation);
    }

    IEnumerator RestoreMana()
    {
        isRestoringMana = true;
        while(mana < MANA)
        {
            ++mana;
            // Update UI
            playerStaminaBar.UpdateUI(new Health { currentHealth = mana, totalHealth = MANA });
            yield return new WaitForSeconds(RESTORING_TIME);
        }
        isRestoringMana = false;
    }

    IEnumerator StartTaunt()
    {
        EnemyController[] nearbyEnemies = FindObjectsOfType<EnemyController>();
        if (!(nearbyEnemies.Length == 0))
        {
            foreach (EnemyController enemy in nearbyEnemies) {
                enemy.taunted = true;
            }
            isTaunting = true;
            _controller.SetIsTaunting(isTaunting);
            anim.SetTrigger("PlayerTauntAnimTrigger");
            yield return new WaitForSeconds(TAUNTING_TIME);
            foreach (EnemyController enemy in nearbyEnemies)
            {
                enemy.taunted = false;
            }
            isTaunting = false;
            _controller.SetIsTaunting(isTaunting);
            anim.SetTrigger("PlayerReturnTauntAnimTrigger");
        }
    }

    void Dash()
    {
        if (Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") != 0)
        {
            //Player dash mechanic
            if (Input.GetButtonDown("Fire1") && !isDashing && (mana > MANA_COMSUNPTION) && !PauseMenuController.isPaused)
            {
                movementSpeed = DASH_SPEED;
                mana -= MANA_COMSUNPTION;
                // Update UI
                playerStaminaBar.UpdateUI(new Health { currentHealth = mana, totalHealth = MANA });
                StartCoroutine(MakeTrail());
                if(!isRestoringMana) StartCoroutine(RestoreMana());
            }
        }
    }

    void Taunt()
    {
        //Player taunt mechanic
        if (Input.GetButtonDown("Fire2") && !isTaunting && !PauseMenuController.isPaused)
        {
            StartCoroutine(StartTaunt());
        }
    }

    public override void Move()
    {
        //Player movement
        _velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        _controller.move(_velocity * Time.deltaTime * movementSpeed);
        // Grab our current _velocity to use as a base for all calculations
        _velocity = _controller.velocity;
    }

    // The Update loop contains a very simple example of moving the character around
    void Update()
    {
        Taunt();
        Dash();
        Move();
    }

}
