using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MouseFrenzy : MonoBehaviour
{
    public Button[] itemButtons;
    public GameObject MouseCharacter;

    public int[] ItemAmounts;

    // Start is called before the first frame update
    void Start()
    {
        ItemAmounts[0] = PlayerPrefs.GetInt("I_Am");
        if (ItemAmounts[0] < 0)
        {
            ItemAmounts[0] = 0;
        }

        if (ItemAmounts[0] > 0) 
        {
            itemButtons[0].gameObject.SetActive(true);
        }
        else
        {
            itemButtons[0].gameObject.SetActive(false);
        }



    }

    // Update is called once per frame
    void Update()
    {

    }


    public void MouseFrenzyTime()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(MouseCharacter, new Vector3(Random.Range(-11, 11), Random.Range(-3.5f, 3), 0), Quaternion.identity);
           
            
        }
        ItemAmounts[0] -= 1;
        PlayerPrefs.SetInt("I_Am", ItemAmounts[0]);
    }


    public void FreezeMouse()
    {

    }

    public void TopSpeed (){

        }
}
