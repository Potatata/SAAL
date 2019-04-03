using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 currentPosition;

    public int health = 3;

    public float speed = 1f;

    float horizontalMovement = 0f;
    float verticalMovement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //TODO Change movement to a separate method
        horizontalMovement = verticalMovement = 0f;

        if (Input.GetAxis("Horizontal") > 0) horizontalMovement = speed;
        else if (Input.GetAxis("Horizontal") < 0) horizontalMovement = -speed;

        if (Input.GetAxis("Vertical") > 0) verticalMovement = speed;
        else if (Input.GetAxis("Vertical") < 0) verticalMovement = -speed;

        transform.position += (Vector3)(new Vector2(horizontalMovement, verticalMovement));
    }
}
