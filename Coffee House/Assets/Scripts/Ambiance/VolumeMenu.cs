using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeMenu : MonoBehaviour
{
    public AudioMixer masterVolumeMixer;
    public AudioMixer musicVolumeMixer;
    public Slider masterVolumeSlider;
    public Slider musicVolumeSlider;

    private void Update()
    {
        SetMasterVolume();
        SetMusicVolume();
    }

    public void SetMasterVolume()
    {
        masterVolumeMixer.SetFloat("ResonanceMasterVolume", masterVolumeSlider.value);
    }

    public void SetMasterVolumeSlider(float vol)
    {
        masterVolumeSlider.value = vol;
    }

    public void SetMusicVolume()
    {
        musicVolumeMixer.SetFloat("MusicVolume", musicVolumeSlider.value);
    }

    public void SetMusicVolumeSlider(float vol)
    {
        musicVolumeSlider.value = vol;
    }
}
