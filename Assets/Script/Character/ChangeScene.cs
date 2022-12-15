using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator animator;
    public Animator fadeAnimator;
    public string sceneName;
    public GameObject lamp;
    public bool PlayerInRange;
    public Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null) { 
            if (animator.GetBool("IsOpen"))
            {
                collider.enabled = true;
            }
            else
            {
                collider.enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;

            fadeAnimator.SetTrigger("FadeOut");
            
        }
    }
}
