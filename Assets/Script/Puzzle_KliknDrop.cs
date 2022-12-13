using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_KliknDrop : MonoBehaviour
{
    public GameObject objectToDrag;
    public GameObject objectToDrop;
    public GameObject gameObjectPanel;

    public float dragDistance;

    public bool isLocked;
    
    [Header("Game Manager")]
    public GameManager gameManager;

    Vector2 objectInItPos;
    // Start is called before the first frame update
    void Start()
    {
        objectInItPos = objectToDrag.transform.position;
        gameManager = FindObjectOfType<GameManager>();
    }

   public void DragObject()
   {
       if (!isLocked)
       {
           objectToDrag.transform.position = Input.mousePosition;
       }
   }
   
   public void DropObject()
   {
       if (isLocked)
       {
           float distance = Vector3.Distance(objectToDrag.transform.position, objectToDrop.transform.position);
           if (distance < dragDistance)
           {
               objectToDrag.transform.position = objectToDrop.transform.position;
               isLocked = true;
               
           }
           else
           {
               objectToDrag.transform.position = objectInItPos;
               
           }
       }
   }
   
   //finish script above this line
   
    public void CheckIfFinished()
    {
         if (isLocked)
         {
             gameObjectPanel.SetActive(false);
             gameManager.counter++;
         }
    }

}
