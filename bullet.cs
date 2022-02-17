using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
     GameObject Spaceship;


    private void Start()
    {
        Spaceship = GameObject.Find("alien ship");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
        if (Spaceship.GetComponent<Damage>().health == 0)
        {
            Destroy(collision.gameObject);
        }
    }
}
