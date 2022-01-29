using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueGame : MonoBehaviour
{
    private Touch theTouch;


    public GameObject pausemenu;
    private Collider2D mouseCollider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

    }
    public void PauseGame()
    {
        
        Time.timeScale = 1;
        pausemenu.SetActive(false);
    }
}
