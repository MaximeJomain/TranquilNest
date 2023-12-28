using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class RainButton : MonoBehaviour
{
    public ParticleSystem rainParticleSystem;
    public AudioSource audioRain;
    public Material rainSkybox;
    
    private Material defaultSkybox;

    private void Awake()
    {
        defaultSkybox = RenderSettings.skybox;
    }

    public void TriggerRainWeather()
    {
        if (RenderSettings.skybox == defaultSkybox
            && !audioRain.isPlaying
            && !rainParticleSystem.isPlaying)
        {
            RenderSettings.skybox = rainSkybox;
            audioRain.Play();
            rainParticleSystem.Play();
        }
        else
        {
            RenderSettings.skybox = defaultSkybox;
            audioRain.Stop();
            rainParticleSystem.Stop();
        }
    }
}
