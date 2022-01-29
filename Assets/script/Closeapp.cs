using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closeapp : MonoBehaviour
{
    private Touch theTouch;

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
        Application.Quit();
    }
}