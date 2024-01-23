using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusicPlayer : MonoBehaviour
{

    AudioSource backgroundMusic;
    private bool isPlaying;
    [SerializeField]
    public Image logo;
    public Sprite pauseLogo, playLogo;
    public Slider volum;
    public Text volumSum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TriggerMusicPlayer();
    }

    public void TriggerMusicPlayer()
    {
        Debug.Log("clic" + logo);
        isPlaying = !isPlaying;

        if(isPlaying && backgroundMusic.isPlaying)
        {
            backgroundMusic.Play();
            logo.sprite = pauseLogo;

        } else
        {
            backgroundMusic.Stop();
            logo.sprite = playLogo;
        }

    }

}
