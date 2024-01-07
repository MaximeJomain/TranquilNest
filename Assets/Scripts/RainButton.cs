using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

public class RainButton : MonoBehaviour
{
    [FormerlySerializedAs("rainParticleSystem")]
    public ParticleSystem rainPS;
    public AudioSource audioRain, audioDefault;
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
