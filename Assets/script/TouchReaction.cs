using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TouchReaction : MonoBehaviour
{
    public int score;
    public int tempScore;
    public Text phaseDisplaytext;


    // Start is called before the first frame update
    void Start()
    {
        tempScore = PlayerPrefs.GetInt("P_Am");
    }

    // Update is called once per frame
    void Update()
    {
        phaseDisplaytext.text = score.ToString();

    }

    public void NextScene()
    {
        Time.timeScale = 1;
        tempScore = tempScore + score;

        PlayerPrefs.SetInt("P_Am", tempScore);
        SceneManager.LoadScene("startscene");
        

    }
}
