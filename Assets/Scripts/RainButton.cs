using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class RainButton : MonoBehaviour
{
    public Material rainSkybox;
    public float fogDensity;
    public float lightIntensity;
    
    private ParticleSystem rainPS;
    private AudioSource audioRain, audioDefault;
    private Material defaultSkybox;
    private float defaultFog;
    private float defaultLight;
    private Light directLight;
    private bool weatherToggle;
    [SerializeField]
    public Image background;
    public Sprite rainLogo, sunLogo;
    

    private void Awake()
    {
        directLight = GameObject.Find("Directional Light").GetComponent<Light>();
        defaultSkybox = RenderSettings.skybox;
        defaultFog = RenderSettings.fogDensity;
        defaultLight = directLight.intensity;
        rainPS = GameObject.Find("Particles/Rain").GetComponent<ParticleSystem>();
        audioRain = GameObject.Find("Audio Rain").GetComponent<AudioSource>();
        audioDefault = GameObject.Find("Audio Default").GetComponent<AudioSource>();
    }

    private void Update()
    {
        ChangeBackground();
    }

    public void TriggerRainWeather()
    {
     //   weatherToggle = !weatherToggle; 
            
        
        // Rain On
        if (RenderSettings.skybox == defaultSkybox
            && !audioRain.isPlaying
            && !rainPS.isPlaying
            && audioDefault.isPlaying)
        {
            weatherToggle = true;
            RenderSettings.skybox = rainSkybox;
            RenderSettings.fogDensity = fogDensity;
            directLight.intensity = lightIntensity;
            DynamicGI.UpdateEnvironment();
            audioDefault.Stop();
            audioRain.Play();
            rainPS.Play();

        }
        // Rain Off
        else
        {
            weatherToggle = false;
            RenderSettings.skybox = defaultSkybox;
            RenderSettings.fogDensity = defaultFog;
            directLight.intensity = defaultLight;
            DynamicGI.UpdateEnvironment();
            audioRain.Stop();
            rainPS.Stop();
            audioDefault.Play();
        }
    }

    public void ChangeBackground()
    {
        if (weatherToggle)
        {
            background.sprite = rainLogo;
        }
        else
        {
            background.sprite = sunLogo;
        }
    }
}
