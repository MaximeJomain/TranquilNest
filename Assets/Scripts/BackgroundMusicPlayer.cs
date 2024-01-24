using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusicPlayer : MonoBehaviour
{

    AudioSource backgroundMusic;
    private bool isPlaying;
    [SerializeField]
    public Image playerButton;
    public Sprite pauseLogo, playLogo;
    public Slider musicVolume;
    public Text volumeText;


    // Start is called before the first frame update
    public void Awake()
    {
        backgroundMusic = GameObject.Find("Audio Background").GetComponent<AudioSource>();
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

    public void OnVolumeChange(float number)
    {
        backgroundMusic.volume = number;
        volumeText.text = number + "%";
    }

}
