using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLamp : MonoBehaviour
{
    public GameObject lamp, interactUI;

    public AudioSource saklarAudio;
    
    public bool PlayerInRange;

    [Header("Collider Settings")] 
    public Collider2D[] colliders;
    
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
                saklarAudio.Play();
                colliders[0].enabled = false;
                colliders[1].enabled = false;
            }
            else
            {
                lamp.SetActive(true);
                interactUI.SetActive(true);
                saklarAudio.Play();
                colliders[0].enabled = true;
                colliders[1].enabled = true;
                
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
