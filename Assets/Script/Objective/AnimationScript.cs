using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;
    public GameObject interactUI;
    public bool PlayerInRange;
    public AudioSource audioSource;
 
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
            if (animator.GetBool("IsOpen"))
            {
                animator.SetBool("IsOpen", false);
                audioSource.Stop();
            }
            else
            {
                animator.SetBool("IsOpen", true);
                
                audioSource.Play();
                collider.enabled = false;
            }

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
