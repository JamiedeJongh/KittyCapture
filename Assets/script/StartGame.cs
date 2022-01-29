using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    private Touch theTouch;

    

    public LevelSelect levelselecterscript;

    // Start is called before the first frame update
    void Start()
    {
        levelselecterscript = GameObject.FindObjectOfType(typeof(LevelSelect)) as LevelSelect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        if (levelselecterscript.LevelSelecter == 1)
        {
            SceneManager.LoadScene("MouseaCheese");
        } else if (levelselecterscript.LevelSelecter == 2)
        {
            SceneManager.LoadScene("FishaWater");
        }
        else if (levelselecterscript.LevelSelecter == 3)
        {
            SceneManager.LoadScene("AntaDirt");
        }
    }
}
