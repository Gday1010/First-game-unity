using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ememydamage : MonoBehaviour
{
    public int health = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        health--;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
