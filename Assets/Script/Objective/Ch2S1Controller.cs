using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2S1Controller : MonoBehaviour
{
    public float chapterBoxdelay = 0f;
    public GameObject Chapter2box;
    public GameObject jurnalPanel;
    // Start is called before the first frame update
    void Start()
    {
        Chapter2box.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        chapterBoxdelay -= Time.deltaTime;
        if (chapterBoxdelay <= 0f)
        {
            Chapter2box.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Chapter2box.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            jurnalPanel.SetActive(true);
        }
        if (jurnalPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                jurnalPanel.SetActive(false);
            }
        }
    }
}
