using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1S1Controller : MonoBehaviour
{
    public float chapterBoxdelay = 0f;
    public GameObject Chapter1box;
    public Animator animator;
    public GameObject Questbox;
    public GameObject pauseButton;
    public GameObject jurnalButton;
    public GameObject jurnalPanel;
    public GameObject quest1;
    public GameObject quest1_1;
    public GameObject quest1_2;
    public GameObject quest2;

    // Start is called before the first frame update
    void Start()
    {
        Chapter1box.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        chapterBoxdelay -= Time.deltaTime;
        if (chapterBoxdelay <= 0f) { 
            Chapter1box.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || chapterBoxdelay <= 0f)
        {
            Chapter1box.SetActive(false);
            pauseButton.SetActive(true);
            if (!quest2.activeInHierarchy)
            {
                Questbox.SetActive(true);
                quest1.SetActive(true);
            }
            else
            {
                Questbox.SetActive(true);
                quest2.SetActive(true);
            }
        }

        if (animator.GetBool("IsOpen"))
        {
            jurnalButton.SetActive(true);
            quest1_1.SetActive (false);
            if (Input.GetKeyDown(KeyCode.B))
            {
                quest1_2.SetActive(false);
                quest1.SetActive(false);
                Time.timeScale = 0;
                
                quest2.SetActive(true);
                jurnalPanel.SetActive(true);
            }
        }

        if (jurnalPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 1;
                jurnalPanel.SetActive(false);
            }
        }
        
    }
}
