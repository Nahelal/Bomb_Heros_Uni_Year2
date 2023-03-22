using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Movement_1 : NetworkBehaviour
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

    //list of player spawn locations
    [SerializeField] private List<Vector2> spawnPositionList;

    private void Awake()
    {
        rigid_body = GetComponent<Rigidbody2D>();
    }

    public override void OnNetworkSpawn()
    {
        //spawns player at specific location depending on join order to the client
        transform.position = spawnPositionList[(int)OwnerClientId];

    }

    private void Update()
    {
        if (!IsOwner)
        {
            return;
        }

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

}
