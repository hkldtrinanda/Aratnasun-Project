using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    public GameObject[] hearts;

    public int life;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            Destroy(hearts[0].gameObject);
            Debug.Log("You died");
        }
        else if (life <= 25)
        {
            Destroy(hearts[1].gameObject);
            Debug.Log("You have 1 heart left");
        }
        else if (life <= 45)
        {
            Destroy(hearts[2].gameObject);
            Debug.Log("You have 2 hearts left");
        }
        else if (life <= 75)
        {
            Destroy(hearts[3].gameObject);
            Debug.Log("You have 3 hearts left");
        }
        else if (life <= 100)
        {
            Destroy(hearts[4].gameObject);
            Debug.Log("You have 4 hearts left");
        }
        
        
        
    }

    public void TakeDamage(int damage)
    {
        life -= damage;
    }
}
