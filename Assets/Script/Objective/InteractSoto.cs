using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSoto : MonoBehaviour
{

    public GameObject interactUI;
    public GameObject soto;
    public GameObject quest1;
    public AudioSource audioSource;
    public bool PlayerInRange;

    public Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bila interaksi dalam jarak yg telah ditentukan, maka true
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            audioSource.Play();
            soto.SetActive(false);
            quest1.SetActive(false);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Bila Collision deteksi tag "Player", maka
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(true);
            PlayerInRange = true;

            /*gameManager.counter++;*/
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Bila Collision deteksi tag "Player" keluar, maka
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(false);
            PlayerInRange = false;
        }
    }
}
