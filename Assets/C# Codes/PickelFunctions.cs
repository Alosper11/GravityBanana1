using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickelFunctions : MonoBehaviour
{
    public float left;
    public float right;
    public float baseSpeed;
    Rigidbody2D rd;
    SpriteRenderer sr;
    public GameObject toClone;

    private void Start()
    {

        rd = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        rd.velocity = new Vector2(baseSpeed * Mathf.Sign(rd.velocity.x), rd.velocity.y);
        if (transform.position.x < left || transform.position.x > right)
        {
            rd.velocity = new Vector2(rd.velocity.x * -1,rd.velocity.y);
            sr.flipX = !sr.flipX;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<AdvancedSpriteSheetAnimation>().Activate("BOB_Die");
            Destroy(collision.gameObject.GetComponent<Movment>());
            collision.gameObject.AddComponent<DieDieDie>();
        }
    }
}
