using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine;

public class Volumetoggle : MonoBehaviour
{

    public AudioMixer MuisGeluid;
    public Slider AudioVolumeSlider;
    public Toggle AudioMute;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    public void ChangeAudioTime()
    {
        
    }

    public void SetLevel(float sliderValue)
    {
        MuisGeluid.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    public void MuteAudio(bool toggleValue)
    {
        if (toggleValue == true)
        {
            MuisGeluid.SetFloat("MusicVol", -80f);
        }
        if (toggleValue == false)
        {
            MuisGeluid.SetFloat("MusicVol", 0);
        }
    }

    public void Update()
    {
        
    }
}
