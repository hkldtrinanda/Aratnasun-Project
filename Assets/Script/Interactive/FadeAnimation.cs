using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeAnimation : MonoBehaviour
{
    [Header("Scene to load")]
    public string sceneName;

    public void startGame()
    {
        SceneManager.LoadScene(sceneName);
    }
}
