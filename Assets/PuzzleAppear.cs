using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAppear : MonoBehaviour
{
    public int puzzleNumber;
    public GameManager gameManager;
    public GameObject objectToappear;
    public Collider2D puzzleCollider;
    public WalkingSimulator walkingSimulator;
    
    // Start is called before the first frame update
    void Start()
    {
        objectToappear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.counter == puzzleNumber)
        {
            objectToappear.SetActive(true);
            puzzleCollider.enabled = false;
            walkingSimulator.MovementSpeed = 2;
        }
 
    }
}
