using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

public class RainButton : MonoBehaviour
{
    public Material rainSkybox;
    
    private ParticleSystem rainPS;
    private AudioSource audioRain, audioDefault;
    private Material defaultSkybox;

    private void Awake()
    {
        defaultSkybox = RenderSettings.skybox;
        rainPS = GameObject.Find("Particles/Rain").GetComponent<ParticleSystem>();
        audioRain = GameObject.Find("Audio Rain").GetComponent<AudioSource>();
        audioDefault = GameObject.Find("Audio Default").GetComponent<AudioSource>();
    }

    public void TriggerRainWeather()
    {
        if (RenderSettings.skybox == defaultSkybox
            && !audioRain.isPlaying
            && !rainPS.isPlaying
            && audioDefault.isPlaying)
        {
            RenderSettings.skybox = rainSkybox;
            audioDefault.Stop();
            audioRain.Play();
            rainPS.Play();
        }
        else
        {
            RenderSettings.skybox = defaultSkybox;
            audioRain.Stop();
            rainPS.Stop();
            audioDefault.Play();
        }
    }
}
