using UnityEngine;

public class ArrowFollow : MonoBehaviour
{
    public Transform targetObject; // The object the arrow will follow
    public float followSpeed = 5f; // The speed at which the arrow will follow the target
    public float rotationDamping = 10f; // The rate at which the arrow's rotation will catch up to the target

    void Update()
    {
        if (targetObject != null)
        {
            // Calculate the direction from the arrow to the target
            Vector3 direction = targetObject.position - transform.position;

            // Normalize the direction vector
            direction.Normalize();

            // Calculate the rotation needed to look at the target
            Quaternion rotation = Quaternion.LookRotation(direction);

            // Smoothly rotate the arrow towards the target using rotation damping
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationDamping * Time.deltaTime);

            // Move the arrow towards the target
            transform.position += transform.forward * followSpeed * Time.deltaTime;
        }
        else
        {
            Debug.LogWarning("Target object is not assigned!");
        }
    }
}
