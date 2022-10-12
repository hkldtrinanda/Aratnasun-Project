using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLamp : MonoBehaviour
{
    public GameObject lamp, interactUI;
    public bool PlayerInRange;
    // Start is called before the first frame update
    void Start()
    {
        lamp.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (lamp.activeInHierarchy)
            {
                lamp.SetActive(false);
                

                
            }
            else
            {

                lamp.SetActive(true);
                interactUI.SetActive(true);
                // dialogText.text = dialog;
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(true);
            PlayerInRange = true;
            
            /*gameManager.counter++;*/
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(false);
            PlayerInRange = false;
            

        }
    }
}
