using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetIndicator : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed;
    public float additionalRotation = 90f; // Additional rotation in degrees

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        Vector3 targetDirection = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);

        // Add additional rotation
        targetRotation *= Quaternion.Euler(0, additionalRotation, 0);

        // Smoothly rotate towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
