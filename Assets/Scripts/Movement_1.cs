using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_1 : MonoBehaviour
{
    //defining move speed, keys and character rigidbody
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
        rigid_body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //player movement set to whatever the corresponding movement keys are for the player
        if (Input.GetKey(up))
        {
            //moves player upwards
            SetDirection(Vector2.up);
        }

        else if (Input.GetKey(down))
        {
            //moves player downwards
            SetDirection(Vector2.down);
        }

        else if (Input.GetKey(left))
        {
            //moves player left
            SetDirection(Vector2.left);
        }

        else if (Input.GetKey(right))
        {
            //moves player right
            SetDirection(Vector2.right);
        }

        else
        {
            //if player isnt pressing any recognised keys, player doesnt move
            SetDirection(Vector2.zero);
        }
    }

    private void FixedUpdate()
    {
        //moves character in player input direction 
        Vector2 position = rigid_body.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        GetComponent<Rigidbody2D>().MovePosition(position + translation);
    }

    private void SetDirection(Vector2 NewDirection )
    {
        //updates direction of player depending on key press input every tick
        direction = NewDirection;
    }

    private void OnTriggerEnter2D(Collider2D explosionCollision)
    {
        if (explosionCollision.gameObject.layer ==LayerMask.NameToLayer("Explosion"))
        {
            //if player gets hit by explosion, they die
            PlayerDeath();
        }
    }

    private void PlayerDeath()
    {
        //disables player movement and bomb placement on death
        enabled = false;
        GetComponent<Bomb>().enabled = false;

        //SHOULD MAYBE ROTATE PLAYER 90 DEGREES SINCE NO DEATH ANIM??

        //delay for player death
        Invoke(nameof(Dead), 1f);
    }

    private void Dead()
    {
        //player is fully disabled and gone after delay
        gameObject.SetActive(false);

        //refs winstatetriggered to check if the game has been won
        FindObjectOfType<WinStateChecker>().WinStateTriggered();
    }
}
