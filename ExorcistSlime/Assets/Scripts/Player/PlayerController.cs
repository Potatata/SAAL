using UnityEngine;
using Prime31;
using System.Collections;

public class PlayerController : CharacterController
{
    //Constants
    private const float SPEED = 16f;
    private const int SALT_PARTICLES = 16 ;
    private const float DASH_SPEED = SPEED*3;
    private const float DASH_TIME = 0.0001f;
    private const int MANA_COMSUNPTION = 20;
    private const int MANA = 60;
    private const float RESTORING_TIME = 0.1f;

    // Movement configuration
    public int mana = MANA;

    //Fields
    private TopDownMovementController2D _controller;
	private Vector3 _velocity;
    public GameObject saltPrefab;
    public bool isDashing = false;
    public bool isRestoringMana = false;
    UIComponent playerStaminaBar;

    void Awake()
	{
        playerStaminaBar = GameObject.FindGameObjectWithTag("PlayerStaminaBar").GetComponent<UIComponentPlayerStaminaBar>();
        playerStaminaBar.Show();
        _controller = GetComponent<TopDownMovementController2D>();
        movementSpeed = SPEED;
    }

    IEnumerator MakeTrail()
    {
        isDashing = true;
        _controller.SetInvencibility(true);
        for (int i = 0; i < SALT_PARTICLES; i++)
        {
            LeaveTrail();
            yield return new WaitForSeconds(DASH_TIME);

        }
        movementSpeed = SPEED;
        isDashing = false;
        _controller.SetInvencibility(false);
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

    void Dash()
    {
        if (Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") != 0)
        {
            //Player dash mechanic
            if (Input.GetButtonDown("Fire1") && !isDashing && (mana > MANA_COMSUNPTION))
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
        Dash();
        Move();
    }

}
