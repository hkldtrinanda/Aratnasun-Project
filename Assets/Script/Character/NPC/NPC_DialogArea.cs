using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_DialogArea : MonoBehaviour
{
    private bool PlayerInRange;
    private bool oneTime = false;
    public GameObject dialog;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bila interaksi dalam jarak yg telah ditentukan, maka true
        if (PlayerInRange && !oneTime)
        {
            dialog.SetActive(true);
            //Selesaikan Dialog
            while (dialog.GetComponent<Dialog>().textIsDone == false) {
                continue;
            }
            oneTime = true;
        }
        else { 
            dialog.SetActive(false);
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
