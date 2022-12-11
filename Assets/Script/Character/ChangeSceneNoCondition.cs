using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneNoCondition : MonoBehaviour
{
    /* Change Scene biasa tidak ada kondisi apapun
       berbeda dengan script change scene lainnya
       yang menggunakan kondisi tertentu */

    public Animator fadeAnimator;
    public string sceneName;
    public Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            fadeAnimator.SetTrigger("FadeOut");
            /*gameManager.counter++;*/
        }
    }
}
