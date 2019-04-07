using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController
{
    public Vector2 currentPosition;

    float horizontalMovement = 0f;
    float verticalMovement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        currentPosition = transform.position;
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        horizontalMovement = verticalMovement = 0f;

        if (Input.GetAxis("Horizontal") > 0f)
        {
            horizontalMovement = speed;
        }
        else if (Input.GetAxis("Horizontal") < 0f)
        {
            horizontalMovement = -speed;
        }

        if (Input.GetAxis("Vertical") > 0f)
        {
            verticalMovement = speed;
        }
        else if (Input.GetAxis("Vertical") < 0f)
        {
            verticalMovement = -speed;
        }

        transform.position += (Vector3)(new Vector2(horizontalMovement, verticalMovement));
    }
}
