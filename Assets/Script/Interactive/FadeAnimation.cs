using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeAnimation : MonoBehaviour
{
    [Header("Scene to load")]
    public string sceneName;

    public AudioSource audio;

    public void startGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void sfxFade()
    {
        audio.Play();
    }
}
