using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2OpeningCutscene : MonoBehaviour
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
        SoundManager.Instance.changeMusic();
        StartCoroutine(DelayLoadLevel(43));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
            if (secondsLeft < 28)
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
