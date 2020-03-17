using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public enum AnimationMode { Stand, Walk, Attack, Die }
    public float TrueSpeed;
    Rigidbody2D rd;
    AdvancedSpriteSheetAnimation animeControler;
    AnimationMode whichAnimationIsRunning;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        animeControler = GetComponent<AdvancedSpriteSheetAnimation>();
        whichAnimationIsRunning = AnimationMode.Stand;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedX = Input.GetAxis("Horizontal");
        float gravity = Input.GetAxis("Vertical");
        if(gravity != 0)
        {
            if (gravity > 0)
            {
                sr.flipY = true;
                rd.gravityScale = -1;
            }
            else
            {
                sr.flipY = false;
                rd.gravityScale = 1;
            }
        }
        if (speedX != 0)
        {
            if (speedX > 0)
                sr.flipX = true;
            else
                sr.flipX = false;
            rd.velocity = new Vector2(speedX * TrueSpeed, rd.velocity.y);
            if (whichAnimationIsRunning != AnimationMode.Walk)
            {
                animeControler.Activate("GBWalk");
                whichAnimationIsRunning = AnimationMode.Walk;
            }
        }
        else
        {
            if (whichAnimationIsRunning != AnimationMode.Stand)
            {
                animeControler.Activate("GBStand");
                whichAnimationIsRunning = AnimationMode.Stand;
            }
        }
    }
}
