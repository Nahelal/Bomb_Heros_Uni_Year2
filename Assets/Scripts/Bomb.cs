using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    //defining input key for placing bombs, player inventory for bombs, and how long it takes for them to detonate
    public GameObject playerBomb;
    public KeyCode placeBomb = KeyCode.Space;

    public int bombMax = 1;
    private int bombsLeft;

    public float bombExplodeTime = 3f;

    private void OnEnable()
    {
        bombsLeft = bombMax;
    }

    private void Update()
    {
        //if player has a bomb in their inventory when they press space bar, they drop a bomb on the map 
        if (bombsLeft > 0 && Input.GetKey(placeBomb))
           StartCoroutine (DropBomb());
    }

    private IEnumerator DropBomb()
    {
        //drops bomb on next closest whole tile to the player
        Vector2 position = transform.position;
        position.x = Mathf.Round(position.x);
        position.y = Mathf.Round(position.y);

        //spawn bomb in map + reduce bombs player has remaining to 0
        GameObject bomb = Instantiate(playerBomb, position, Quaternion.identity);
        bombsLeft = 0;

        //waits 3 seconds before continuing to let the bomb explode and do damage
        yield return new WaitForSeconds(bombExplodeTime);

        //testing if works before adding explosions
        Destroy(bomb);
        bombsLeft = 1;
    }
}
