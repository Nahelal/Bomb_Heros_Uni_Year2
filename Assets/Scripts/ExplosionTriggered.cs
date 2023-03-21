using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ExplosionTriggered : NetworkBehaviour
{
    // ref to animation sequence in the prefab
    public ExplosionAnimation Centre;
    public ExplosionAnimation Middle;
    public ExplosionAnimation End;

    public void SetActiveRenderer(ExplosionAnimation renderer)
    {
        // enables either centre, mid, or end depending on which is called
        Centre.enabled = renderer == Centre;
        Middle.enabled = renderer == Middle;
        End.enabled = renderer == End;
    }

    public void SetDirection(Vector2 direction)
    {
        //changes direction of the anim to fit where the bomb is and the uncovered areas of map
        float angle = Mathf.Atan2(direction.y, direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }
}
