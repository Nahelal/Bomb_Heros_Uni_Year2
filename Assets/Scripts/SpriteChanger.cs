using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class SpriteChanger : NetworkBehaviour
{
    //LIST OF PLAYER SKINS TO USE
    [SerializeField] private List<Sprite> playerSkins;
    public SpriteRenderer spriteRenderer;

    public override void OnNetworkSpawn()
    {
        //changes player sprite depending on join order to the server
        spriteRenderer.sprite = playerSkins[(int)OwnerClientId];
    }
}
