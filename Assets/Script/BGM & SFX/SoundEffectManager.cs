using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    public AudioSource sfx;

    public AudioClip[] sfxClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sfxUIButton()
    {
        sfx.clip = sfxClip[0];
        sfx.Play();
    }

    public void sfxOpenJurnal()
    {
        sfx.clip = sfxClip[1];
        sfx.Play();
    }

    public void sfxNextPageJurnal()
    {
        sfx.clip = sfxClip[2];
        sfx.Play();
    }
}
