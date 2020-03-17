using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject amunition;
    public float BulletSpeed;
    Rigidbody2D rd;
    AdvancedSpriteSheetAnimation animeControler;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        animeControler = GetComponent<AdvancedSpriteSheetAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            gameObject.AddComponent<ShootGB>();
            gameObject.GetComponent<ShootGB>().toClone = amunition;
            gameObject.GetComponent<ShootGB>().bulletSpeed = BulletSpeed;
        }
    }
}
