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
                Pause.SetActive(true);
                Time.timeScale = 0;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause.SetActive(false);
                Time.timeScale = 1;
            }
        }
        if (options.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            options.SetActive(false);
            Pause.SetActive(true);
        }
        if (credit.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            credit.SetActive(false);
            Pause.SetActive(true);
        }
    }

    public void resume()
    {
        Time.timeScale = 1;
        Pause.SetActive(false);
    }

    public void quitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Ch0 MainMenu");

    }
}
