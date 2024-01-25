using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class BackgroundMusicPlayer : MonoBehaviour
{

    public AudioSource backgroundMusic;
    private bool isPlaying;
    [SerializeField]
    public Image playerButton;
    public Sprite pauseLogo, playLogo;
    public Slider musicVolume;
    public Text volumeText;
    public LinearMapping linearMapping;

    private Slider musicVolumeSlider;


    // Start is called before the first frame update
    public void Awake()
    {
        musicVolumeSlider = musicVolume.GetComponent<Slider>();

        musicVolumeSlider.value = backgroundMusic.volume;
        volumeText.text = backgroundMusic.volume + "%";
        linearMapping.value = 0.5f;
        backgroundMusic.volume = 0.5f;
    }

    private void Update()
    {
        backgroundMusic.volume = linearMapping.value;
        int volume = Mathf.RoundToInt(linearMapping.value * 100);
        volumeText.text = volume + "%";
    }

    public void TriggerMusicPlayer()
    {
        isPlaying = !isPlaying;

        if(isPlaying)
        {
            backgroundMusic.Play();
            playerButton.sprite = pauseLogo;
        } 
        else
        {
            backgroundMusic.Pause();
            playerButton.sprite = playLogo;
        }

    }

    // public void OnVolumeChange(float number)
    // {
    //     int numberInt = Mathf.RoundToInt(number);
    //     backgroundMusic.volume = number;
    //     volumeText.text = numberInt * 100 + "%";
    // }

}
