using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Unity.Netcode;

public class BushDestruction : NetworkBehaviour
{
    public Tilemap Bushes;

    private IEnumerator RemoveBush(Vector2 position)
    //private void RemoveBush(Vector2 position)
    {
        Vector3Int squarePos = Bushes.WorldToCell(position);
        TileBase bush = Bushes.GetTile(squarePos);

        // if the tile has a bush on, it gets destroyed after 1 second
        if (bush != null)
        {

            // delay until bush destroyed
            yield return new WaitForSeconds(1);
            Bushes.SetTile(squarePos, null);
        }
    }

}
