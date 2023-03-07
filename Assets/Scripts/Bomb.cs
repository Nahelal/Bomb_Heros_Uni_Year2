using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

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

    //bush tiles to explode and be destroyed + time delay
    public Tilemap bushTiles;

    //tilemap check for layer
    public LayerMask tilemapLayerCheck;



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

        // explosion goes in the designated direction with the set length from 'explosionLength'
        Explode(position, Vector2.up, explosionLength);
        Explode(position, Vector2.down, explosionLength);
        Explode(position, Vector2.left, explosionLength);
        Explode(position, Vector2.right, explosionLength);

        //testing if works before adding explosions
        Destroy(bomb);
        bombsLeft = 1;
    }

    private void Explode(Vector2 position, Vector2 direction, int length)
    {
        // called as many times as 'explosionLength' is set to and extends the explosion 
        // stops loop if the length of explosion has reached the end
        if (length <= 0)
        {
            return;
        }
        // gets new position to continue explosion from, based on where last explosion tile was
        position += direction;

        //only spawns explosion tiles if there isnt a box collider in the way
        if (Physics2D.OverlapBox(position, Vector2.one / 2f, 0f, tilemapLayerCheck))
        {
            //destroys bush tile if the explosion touched it 
            
            StartCoroutine(RemoveBush(position));
           // RemoveBush(position);
            return;
        }

        // spawns middle section of explosion if 'explosionLength' > 1, else spawns the end sections
        ExplosionTriggered explosion = Instantiate(explosionPrefab, position, Quaternion.identity);
        explosion.SetActiveRenderer(length > 1 ? explosion.Middle : explosion.End);
        explosion.SetDirection(direction);
        Destroy(explosion.gameObject, explosionTime);

        //reduces explosion size by 1 as each tile is spawned in until 'explosionLength' = 0
        Explode(position, direction, length - 1);
    }



    private IEnumerator RemoveBush(Vector2 position)
    //private void RemoveBush(Vector2 position)
    {
        Vector3Int squarePos = bushTiles.WorldToCell(position);
        TileBase bush = bushTiles.GetTile(squarePos);

        // if the tile has a bush on, it gets destroyed after 1 second
        if (bush != null)
        {
            
           // delay until bush destroyed
            yield return new WaitForSeconds(1);
            bushTiles.SetTile(squarePos, null);
        }
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
