using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject Pause;
    public GameObject jurnalPanel;
    public GameObject options;
    public GameObject credit;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Pause.activeInHierarchy && !jurnalPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                audioSource.Play();
                Pause.SetActive(true);
                Time.timeScale = 0;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                audioSource.Play();
                Pause.SetActive(false);
                Time.timeScale = 1;
            }
        }
        if (options.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            audioSource.Play();
            options.SetActive(false);
            Pause.SetActive(true);
        }
        if (credit.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            audioSource.Play();
            credit.SetActive(false);
            Pause.SetActive(true);
        }
    }

    public void resume()
    {
        audioSource.Play();
        Time.timeScale = 1;
        Pause.SetActive(false);
    }

    public void pause()
    {
        audioSource.Play();
        Pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void quitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Ch0 MainMenu");

    }
}
