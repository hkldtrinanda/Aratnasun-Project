using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; set; }

    public AudioSource audio;

    public AudioClip[] musicClip;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeMusic()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case "Ch0 MainMenu":
                audio.Stop();
                audio.clip = musicClip[0];
                audio.Play();
                break;

            case "Ch1-S0 OpeningCutscene":
                audio.Stop();
                break;

            case "Ch1-S1 RuangKerjaAyah":
                audio.Stop();
                audio.clip = musicClip[1];
                audio.Play();
                break;

            case "Ch1-S2 RuangTengah":
                audio.Stop();
                audio.clip = musicClip[2];
                audio.Play();
                break;

            case "Ch1-S3 RuangMakan":
                audio.Stop();
                audio.clip = musicClip[3];
                audio.Play();
                break;

            case "Ch1-S4 EndingCutscene":
                audio.Stop();
                break;

            case "Ch2-S0 OpeningCutscene":
                audio.Stop();
                break;

            case "Ch2-S1 GapuraDepan":
                audio.Stop();
                audio.clip = musicClip[4];
                audio.Play();
                break;

            case "Ch2-S2 Rawa":
                audio.Stop();
                audio.clip = musicClip[5];
                audio.Play();
                break;

            case "Ch2-S3 GapuraDepan":
                audio.Stop();
                audio.clip = musicClip[4];
                audio.Play();
                break;

            case "Ch2-S4 Desa":
                audio.Stop();
                audio.clip = musicClip[4];
                audio.Play();
                break;

            case "Ch2-S5 DalamRumah Fix":
                audio.Stop();
                audio.clip = musicClip[6];
                audio.Play();
                break;

            case "Ch2-S6":
                audio.Stop();
                break;
        }
    }
}
