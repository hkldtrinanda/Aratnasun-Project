using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Scene to load")]
    public string sceneName;
    public Animator animator;

    [Header("All Panel")]
    public GameObject panelAwal;
    public GameObject mainMenu;
    public GameObject options;
    public GameObject credit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mainMenu.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                mainMenu.SetActive(false);
                panelAwal.SetActive(true);
            }
        }

        if (options.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                options.SetActive(false);
                mainMenu.SetActive(true);
            }
        }

        if (credit.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                credit.SetActive(false);
                options.SetActive(true);
            }
        }
    }

    public void FadeOutAnimation()
    {
        animator.SetTrigger("FadeOut");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
