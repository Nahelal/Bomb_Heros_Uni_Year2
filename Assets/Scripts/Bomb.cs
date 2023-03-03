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

    //references the explosion triggered script to run the anims 
    public ExplosionTriggered explosionPrefab;
    //sets base time for explosion to take place, and also the total size of the explosions 
    public float explosionTime = 1f;
    public int explosionLength = 1;

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

        //gets new position of bomb if it was pushed around the map by the player at all
        position = bomb.transform.position;
        position.x = Mathf.Round(position.x);
        position.y = Mathf.Round(position.y);

        // spawns in the centre piece of the explosion anim sequence where the bomb is currently located on the map
        ExplosionTriggered explosion = Instantiate(explosionPrefab, position, Quaternion.identity);
        explosion.SetActiveRenderer(explosion.Centre);
        Destroy(explosion.gameObject, explosionTime);



        //testing if works before adding explosions
        Destroy(bomb);
        bombsLeft = 1;
    }







    private void OnTriggerExit2D(Collider2D bombCheck)
    {
        //if player is no longer on top of the bomb, bomb is no longer a trigger and has correct collisions
        if (bombCheck.gameObject.layer == LayerMask.NameToLayer("Bomb"))
        {
            bombCheck.isTrigger = false;
        }
    }
}
