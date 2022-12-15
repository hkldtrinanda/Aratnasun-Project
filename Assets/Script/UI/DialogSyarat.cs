using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSyarat : MonoBehaviour
{
    public GameManager gameManager;
    public AppearCounterObject appearCounterObject;
    public GameObject dialogNotDone;
    public GameObject dialogDone;
    public bool oneTime = false;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && oneTime == false)
        {
            if (gameManager.counter == appearCounterObject.counterNeeded) { 
                dialogDone.SetActive(true);
                oneTime = true;
            }
            else { 
                dialogNotDone.SetActive(true);
                oneTime = true;
            }
        }
    }
}
