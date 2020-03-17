using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieDieDie : MonoBehaviour
{
    AdvancedSpriteSheetAnimation assa;
    // Start is called before the first frame update
    void Start()
    {
        assa = GetComponent<AdvancedSpriteSheetAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        Sod();
    }

    void Sod()
    {
        if(!assa.Active)
        {
            SceneManager.LoadScene(Application.loadedLevel);
        }
    }
}
