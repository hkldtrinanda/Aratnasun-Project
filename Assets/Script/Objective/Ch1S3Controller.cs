using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1S3Controller : MonoBehaviour
{
    public GameObject jurnalPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
