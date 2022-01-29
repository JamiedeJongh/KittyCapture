using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int Points;
    public bool[] LevelUnlocked;
    public Text Scoretext;

    public GameObject[] BuyButtons;
    public GameObject[] BoughtButtons;

    public int[] itemAmounts;

    // Start is called before the first frame update
    void Start()
    {

        itemAmounts[0] = PlayerPrefs.GetInt("I_Am");

        Points = PlayerPrefs.GetInt("P_Am");
        LevelUnlocked[0] = (PlayerPrefs.GetInt("lvl_UL1") != 0);
        LevelUnlocked[1] = (PlayerPrefs.GetInt("lvl_UL2") != 0);

        if  (LevelUnlocked[0] == true)
        {
            BuyButtons[0].SetActive(false);
            BoughtButtons[0].SetActive(true);
        }
        if (LevelUnlocked[1] == true) 
        {
            BuyButtons[1].SetActive(false);
            BoughtButtons[1].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Your Points: " + Points.ToString();
    }

   public void PointCheckerWater()
    {
        if (Points >= 50)
        {
            LevelUnlocked[0] = true;
            BuyButtons[0].SetActive(false);
            BoughtButtons[0].SetActive(true);
            Points -= 50;
            PlayerPrefs.SetInt("lvl_UL1", (LevelUnlocked[0] ? 1 : 0));
            PlayerPrefs.SetInt("P_Am", Points);
        }
        
    }

   public void PointCheckerDirt()
    {
        if (Points >= 50)
        {
            LevelUnlocked[1] = true;
            BuyButtons[1].SetActive(false);
            BoughtButtons[1].SetActive(true);
            Points -= 50;
            PlayerPrefs.SetInt("lvl_UL2", (LevelUnlocked[0] ? 1 : 0));
            PlayerPrefs.SetInt("P_Am", Points);
        }

    }



    public void MouseFrenzyShopMngr()
    {
        if (Points >= 15)
        {
            itemAmounts[0] += 1;
            Points -= 15;
            PlayerPrefs.SetInt("I_Am", itemAmounts[0]);
            PlayerPrefs.SetInt("P_Am", Points);
        }
    }

    public void FreezeMouseShopMngr()
    {

    }



}
