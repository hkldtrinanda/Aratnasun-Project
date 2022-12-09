using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Option;
    public GameObject Credit;
    public GameObject inventoryButton;
    public GameObject pauseButton;
    public GameObject options;
    public GameObject credit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseButton.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            pauseButton.SetActive(false);
            inventoryButton.SetActive(false);
            Pause.SetActive(true);
            Time.timeScale = 0;
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
        SceneManager.LoadScene("MainMenu");

    }
}
