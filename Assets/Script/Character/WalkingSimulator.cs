using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSimulator : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 5;
    public float JumpForce = 7;
    public bool facingRight = true;
    public Animator anim;
    
    [Header("Respawn")]
    public Vector3 respawnPoint;
    public GameObject fallDetector;

    /*public GameObject bangku = GameObject.FindGameObjectWithTag("Object");*/
    public bool playerInrange;
    /*public Animator animator;*/
    

    // RIGIDBODY 2D
    public Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }
    // Update is called once per frame
    private void Update()
    {
        // KODE MOVEMENT
        var movement = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * MovementSpeed, _rigidbody.velocity.y);
        anim.SetFloat("moveSpeed", Mathf.Abs(_rigidbody.velocity.x));
        // KODE FLIP MOVEMENT
        if (movement < 0 && facingRight) Flip();
        if (movement > 0 && !facingRight) Flip();

        // KODE LOMPAT
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
            fallDetector.SetActive(true);
        }
        else if(collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }
    }
    
    // KODE FLIP MOVEMENT
    private void Flip()
    {
        facingRight = !facingRight;
       
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}