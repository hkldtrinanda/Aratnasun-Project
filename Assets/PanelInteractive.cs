using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PanelInteractive : MonoBehaviour
{
    [Header("Panels Description")]
    public GameObject panel;
    
    [Header("Interaction")]
    public  GameObject interactable;

    [Header("Walking Stop it")] 
    public WalkingSimulator stopWalk;
    
    public bool playerInRange;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            if (panel.activeInHierarchy)
            {
                panel.SetActive(false);
                
                stopWalk.MovementSpeed = 2f;
                stopWalk.JumpForce = 4f;
            }
            else
            {
                panel.SetActive(true);
                
                stopWalk.MovementSpeed = 0;
                stopWalk.JumpForce = 0;
            }
        }
    }

    public void onClick()
    {
        panel.SetActive(false);
        stopWalk.MovementSpeed = 2f;
        stopWalk.JumpForce = 4f;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            interactable.SetActive(true);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            interactable.SetActive(false);
            panel.SetActive(false);
        }
    }
}
