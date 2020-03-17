using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGB : MonoBehaviour
{
    enum AnimationMode { Stand,Shoot}
    public GameObject toClone;
    public float bulletSpeed;
    AdvancedSpriteSheetAnimation animeControler;
    SpriteRenderer sr;
    AnimationMode whichAnimationIsRunning;
    bool firstTime;
    // Start is called before the first frame update
    void Start()
    {
        firstTime = true;
        animeControler = GetComponent<AdvancedSpriteSheetAnimation>();
        animeControler.Activate("GBThrow");
        whichAnimationIsRunning = AnimationMode.Shoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (!animeControler.Active && firstTime)
        {
            GameObject shot = Instantiate(toClone);
            shot.transform.position = new Vector2(transform.position.x + (sr.flipX == true ? -1 : 1) * bulletSpeed, transform.position.y);
            shot.AddComponent<HandleShots>();
            animeControler.Activate("GBStand");
            firstTime = false;
            Destroy(gameObject.GetComponent<ShootGB>());
        }
    }
}
