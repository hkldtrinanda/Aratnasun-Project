using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChasing : MonoBehaviour
{
    public GameObject player;

    public float speed;
    public float distanceBetween;
    
    private float distance;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        
        //Dont Use This (This Script For Chasing Player)
        /*float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;*/

        if (distance < distanceBetween)
        {
            
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            
            //Dont Use This (This Script For Chasing Player)
            /*transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);*/
            /*transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);*/
        }
    }
}
