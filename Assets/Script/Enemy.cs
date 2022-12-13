using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    
    [Header ("Audio Got Damaged")]
    public AudioSource audioSource;
    
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject, 5f);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        audioSource.Play();
        Debug.Log("Enemy took damage");
    }
}
