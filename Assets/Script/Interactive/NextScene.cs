using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class NextScene : MonoBehaviour
{
    [Header("Scene to load")]
    public string sceneName;

    bool loadingStarted = false;
    float secondsLeft = 0;
    public GameObject skipButton;

    void Start()
    {
        StartCoroutine(DelayLoadLevel(81));
    }
    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
            if (secondsLeft < 66)
            {
                skipButton.SetActive(true);
            }
        } while (--secondsLeft > 0);
        SceneManager.LoadScene(sceneName);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    //void OnGUI()
    //{
    //    if (loadingStarted)
    //        GUI.Label(new Rect(0, 0, 100, 20), secondsLeft.ToString());
    //}
}
