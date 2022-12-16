    using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateScriptPatrolling : MonoBehaviour
{
    [Header("Scripted NonActive When Triggering")]
    public Patrolling patrolling;
    public AIChasing AIChasing;
    // Start is called before the first
    // frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            patrolling.enabled = true;
            AIChasing.enabled = false;

        }
    }
}
