using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    public GameObject musicObject;
    public Slider volumeSlider;

    private AudioSource audio;
    private float musicVolume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        musicObject = GameObject.FindWithTag("Game Music");
        audio = musicObject.GetComponent<AudioSource>();
        musicVolume = PlayerPrefs.GetFloat("volume");
        audio.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        audio.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
