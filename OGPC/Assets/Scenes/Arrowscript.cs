using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowscript : MonoBehaviour
{

    public Transform apple;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(apple.position - transform.position),
            rotationSpeed * Time.deltaTime);
    }
}
