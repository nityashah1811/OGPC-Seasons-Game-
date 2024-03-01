using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Plane")
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
