using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEatsApple : MonoBehaviour
{
    AudioSource crunchSound;

    // Start is called before the first frame update
    void Start()
    {
        crunchSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            crunchSound.Play();
        }
    }
}
