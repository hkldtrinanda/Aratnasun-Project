using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1EndingScene : MonoBehaviour
{
    [Header("Scene to load")]
    public string sceneName;
    public Animator animator;

    bool loadingStarted = false;
    float secondsLeft = 0;
    public GameObject skipButton;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayLoadLevel(28));
    }
    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
            if (secondsLeft < 15)
            {
                skipButton.SetActive(true);
            }
        } while (--secondsLeft > 0);
        animator.SetTrigger("FadeOut");
    }

    public void LoadNextScene()
    {
        animator.SetTrigger("FadeOut");
    }
}
