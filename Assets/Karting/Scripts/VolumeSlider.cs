using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volumeSlider; // Reference to the slider in the scene

    void Start()
    {
        // Set the slider value to the current audio volume
        volumeSlider.value = AudioListener.volume;
    }

    public void SetVolume(float volume)
    {
        // Set the audio listener volume to the value of the slider
        AudioListener.volume = volume;
    }
}

