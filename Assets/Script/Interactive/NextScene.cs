using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [Header("Scene to load")] 
    public string sceneName;
    
    [Header ("Quit With Panel")]
    public GameObject quitPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (quitPanel.activeInHierarchy)
            {
                quitPanel.SetActive(false);
                Debug.Log("Quit Panel is now false");
            }
            else
            {
                quitPanel.SetActive(true);
                Debug.Log("Quit Panel is now true");
            }
        }
        
    }
    
    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
