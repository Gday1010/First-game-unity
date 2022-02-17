using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject player;
    float speed = 1f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }



    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 direction = GameObject.Find("spaceman").transform.position - rb.transform.position;
        rb.MovePosition(rb.transform.position + direction * speed * Time.fixedDeltaTime);
    }
  
  
}


