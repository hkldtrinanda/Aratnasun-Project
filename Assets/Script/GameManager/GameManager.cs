using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int counter;
    public AppearCounterObject appearCounterObject;
    public DialogSyarat dialogSyarat;
    public GameObject dialog;
    public bool oneTime = false;
    
    
    public void Start()
    {
        counter = 0;
    }

    public void Update()
    {
        if (dialogSyarat != null && appearCounterObject != null && dialog != null) { 
            if (dialogSyarat.oneTime == true && counter == appearCounterObject.counterNeeded && oneTime == false)
            {
                dialog.SetActive(true);
                oneTime = true;
            }
        }
    }
}
