using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ExplosionAnimation : NetworkBehaviour
{

    private SpriteRenderer sprite_Renderer;

    // array of anim frames in the anim sequence
    public Sprite[] animatopnSprites;
    
    // if the sequence isnt playing, shows a single frame instead
    public Sprite idleSprite;

    // time in which each part of the anim will show before jumping to the next part, .125 due to there being 8 parts
    public float animationFrameTime = 0.125f;

    // keeps track of which frame in the explosion anim is currently being shown
    private int currentAnimFrame;

    //toggleable looping anim and if the idle is showing currently
    public bool loop = true;
    public bool idle = true;

    private void Awake()
    {
        sprite_Renderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //destroys player script if not the specific player
        //if (!IsOwner) Destroy(this);
    }

    private void  OnEnable()
    {
        // enables the sprite renderer and starts the anim
        sprite_Renderer.enabled = true;
    }

    private void OnDisable()
    {
        // disables the sprite renderer and stops the anim
        sprite_Renderer.enabled = false;
    }

    private void Start()
    {
        // will loop the 'NextAnimPart' function to loop thru the anim sequence for the explosion
        InvokeRepeating(nameof(NextAnimPart), animationFrameTime, animationFrameTime);
    }

    private void NextAnimPart()
    {
        // increments 'currentAnimFrame by 1
        currentAnimFrame++;

        // if looping and at the end of the sequence, go back to the first frame and continue playing
        if (loop && currentAnimFrame >= animatopnSprites.Length)
        {
            currentAnimFrame = 0;
        }

        // calls the idle frame if idle is set to true, otherwise plays the anim sequence
        if (idle)
        {
            sprite_Renderer.sprite = idleSprite;
        }
        else if (currentAnimFrame >= 0 && currentAnimFrame < animatopnSprites.Length)
        {
            sprite_Renderer.sprite = animatopnSprites[currentAnimFrame];    
        }
    }
}
