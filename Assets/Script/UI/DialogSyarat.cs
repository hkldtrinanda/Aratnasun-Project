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
    private bool PlayerInRange;

    private void Update()
    {
        if (gameManager.counter == appearCounterObject.counterNeeded && PlayerInRange == true)
        {
            dialogDone.SetActive(true);
            oneTime = true;
        }
        else if(gameManager.counter != appearCounterObject.counterNeeded && PlayerInRange == true)
        {
            dialogNotDone.SetActive(true);
            oneTime = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Bila Collision deteksi tag "Player", maka
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Bila Collision deteksi tag "Player" keluar, maka
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = false;
        }
    }
}
