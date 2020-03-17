using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleShots : MonoBehaviour
{
    public GameObject[] canImpact;
    Rigidbody2D rd;
    AdvancedSpriteSheetAnimation assa;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        rd.velocity = new Vector2(-1,0);
        assa = GetComponent<AdvancedSpriteSheetAnimation>();
        assa.Activate("existing");
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity = new Vector2(-1, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this);
        for (int i = 0; i < canImpact.Length; i++)
        {
            if (collision.gameObject.Equals(canImpact[i]))
            {

            }
        }
    }
}
