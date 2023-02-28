using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_1 : MonoBehaviour
{

    public Rigidbody2D rigid_body { get; private set; }
    public Vector2 direction = Vector2.down;
    public float speed = 5f;

    //changable key inputs for player if on arrows or wasd
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    private void Awake()
    {
        rigid_body = GetComponent<rigid_body>();
    }

    //player movement set to whatever the corresponding movement keys are for the player
    private void Update()
    {
        if (Input.GetKey(up))
        {
            SetDirection(Vector2.up);
        }

        else if (Input.GetKey(down))
        {
            SetDirection(Vector2.down);
        }

        else if (Input.GetKey(left))
        {
            SetDirection(Vector2.left);
        }

        else if (Input.GetKey(right))
        {
            SetDirection(Vector2.right);
        }

        //if player isnt pressing any recognised keys, player doesnt move
        else
        {
            SetDirection(Vector2.zero);
        }
    }

    //moving player in player input direction which runs on player fps 
    private void FixedUpdate()
    {
        Vector2 position = rigid_body.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        GetComponent<Rigidbody2D>().MovePosition(position + translation);
    }

    //updates direction of player depending on key press input every tick
    private void SetDirection(Vector2 NewDirection )
    {
        direction = NewDirection;
    }

}
