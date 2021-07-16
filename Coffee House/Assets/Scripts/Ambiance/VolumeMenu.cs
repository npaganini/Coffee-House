using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeMenu : MonoBehaviour
{
    public AudioMixer masterVolumeMixer;
    public AudioMixer musicVolumeMixer;
    // public Slider masterVolumeSlider;
    // public Slider musicVolumeSlider;
    private float masterVolume;
    private float musicVolume;

    private void Start()
    {
        masterVolume = 0;
        musicVolume = 0;
    }

    private void Update()
    {
        SetMasterVolume();
        SetMusicVolume();
    }

    public void SetMasterVolume()
    {
        masterVolumeMixer.SetFloat("ResonanceMasterVolume", masterVolume);
    }

    // public void SetMasterVolumeSlider(float vol)
    // {
    //     masterVolumeSlider.value = vol;
    // }

    public void IncreaseMasterVolume()
    {
        masterVolume = masterVolume + 10;
        if (masterVolume > 0)
        {
            masterVolume = 0;
        }
    }

    public void DecreaseMasterVolume()
    {
        masterVolume = masterVolume - 10;
        if (masterVolume < -80.0f)
        {
            masterVolume = -80;
        }
    }

    public void SetMusicVolume()
    {
        musicVolumeMixer.SetFloat("MusicVolume", musicVolume);
    }

    // public void SetMusicVolumeSlider(float vol)
    // {
    //     musicVolumeSlider.value = vol;
    // }

    public void IncreaseMusicVolume()
    {
        musicVolume = musicVolume + 10;
        if (musicVolume > 0)
        {
            musicVolume = 0;
        }
    }

    public void DecreaseMusicVolume()
    {
        musicVolume = musicVolume - 10;
        if (musicVolume < -80.0f)
        {
            musicVolume = -80;
        }
    }
}
