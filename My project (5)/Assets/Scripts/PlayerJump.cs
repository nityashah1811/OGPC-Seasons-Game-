using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody rb;
    public bool playerIsOnTheGround = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0, vertical);
        if (playerIsOnTheGround == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
                playerIsOnTheGround = false;

            }
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerIsOnTheGround = true;
        }
    }
}