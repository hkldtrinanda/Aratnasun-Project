using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact_NPC : MonoBehaviour
{

    [Header("Interaction")]
    public GameObject interactable;

    [Header("Audio Interact")]
    public AudioSource audioSource;

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
            audioSource.Play();
        }
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
        }
    }
}
