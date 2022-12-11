using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Dialog_AfterAnother : MonoBehaviour
{
    private bool PlayerInRange;
    public bool oneTime = false;
    public Animator animator; 
    public GameObject dialog;
    public Collider2D collider;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Bila interaksi dalam jarak yg telah ditentukan, maka true
        if (PlayerInRange && !animator.GetBool("OneTime") && animator.GetBool("IsOpen"))
        {
            dialog.SetActive(true);
            //Selesaikan Dialog
            while (dialog.GetComponent<Dialog>().textIsDone == false)
            {
                Debug.Log("While");
                continue;
            }
            Debug.Log("True");
            oneTime = true;
            collider.enabled = false;
        }
        else
        {
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
