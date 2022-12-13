using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearCounterObject : MonoBehaviour
{
    public int counterNeeded;
    public GameManager gameManager;

    public GameObject objectToAppear;
    public Collider2D col;

    
    // Start is called before the first frame update
    void Start()
    {
        objectToAppear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.counter == counterNeeded)
        {
            objectToAppear.SetActive(true);
            col.enabled = true;
        }

    }

}
