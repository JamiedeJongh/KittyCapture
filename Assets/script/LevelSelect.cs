using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{

    public int LevelSelecter;
    public GameObject StartMenuButtons;
    public GameObject PauseMenuButtons;

    public GameObject WholeCanvas;
    public GameObject LaadScherm;

    public GameObject ShopMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButton()
    {
        StartMenuButtons.SetActive(false);
        PauseMenuButtons.SetActive(true);

    }

    public void BackToMenu()
    {
        StartMenuButtons.SetActive(true);
        PauseMenuButtons.SetActive(false);

    }


    public void ShopButton()
    {
        StartMenuButtons.SetActive(false);
        ShopMenu.SetActive(true);

    }

    public void BackToMenuFromShop()
    {
        StartMenuButtons.SetActive(true);
        ShopMenu.SetActive(false);

    }


    public void Level1()
    {
        LaadScherm.SetActive(true);
        WholeCanvas.SetActive(false);
        SceneManager.LoadScene("MouseaCheese");
    }
    public void Level2()
    {
        LaadScherm.SetActive(true);
        WholeCanvas.SetActive(false);
        SceneManager.LoadScene("FishaWater");
    }

    public void Level3()
    {
        LaadScherm.SetActive(true);
        WholeCanvas.SetActive(false);
        SceneManager.LoadScene("AntaDirt");
    }

}
