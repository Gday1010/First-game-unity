using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int health = 1;

    float invultimer = 0;
    int correctLayer;

    private void Start()
    {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        health --;
        invultimer = 2f;
        gameObject.layer = 10;
    }

    private void Update()
    {
        invultimer -= Time.deltaTime;
        if (invultimer <= 0)
        {
            gameObject.layer = correctLayer;
        }
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
