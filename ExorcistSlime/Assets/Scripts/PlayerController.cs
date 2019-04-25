using UnityEngine;

public class PlayerController : CharacterController
{
    //Constants
    private readonly float INITIAL_SPEED = 0.1f;
    private readonly int INITIAL_HEALTH = 3;

    //Fields
    public Vector2 currentPosition;
    public float dashTime;

    // Start is called before the first frame update
    void Start()
    {
        health = INITIAL_HEALTH;
        PrintHealth();
        currentPosition = transform.position;
        speed = INITIAL_SPEED;
    }

    // Update is called once per frame
    void Update()
    {
        Dash();
        Move();
    }

    public override void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        RaycastHit2D[] results = new RaycastHit2D[16];
        int cnt = GetComponent<Rigidbody2D>().Cast(movement, results, movement.magnitude/3);
        if (cnt > 0)
        {
            speed = 0;
            Debug.Log("I'm colliding!.");
        }
        transform.position = transform.position + movement * speed;
    }

    void Dash()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("DASH!");
            dashTime = Time.deltaTime*10;
            speed = INITIAL_SPEED * 5;
        }
        else
        {
            if (dashTime <= 0.0f) speed = INITIAL_SPEED;
            else dashTime -= Time.deltaTime;
        }
    }

    void PrintHealth()
    {
        healthText.text = "Health: " + health.ToString();
    }

    void OnTriggerEnter2D(Collider2D objectHit)
    {
        //If it hit a bullet
        if (objectHit.gameObject.GetComponent<BulletController>())
        {
            //Take damage and check if he died
            --health;
            PrintHealth();
            if (health <= 0)
                Died();
        }
    }

    void Died()
    {
        Debug.Log("I am deded. Press F to pay respect.");
    }
}
