using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpApple : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PickBackpack;

    void Start()
    {
        PickBackpack.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PickBackpack.SetActive(true);

            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                Applemanager.Instance.IncreaseAppleCount();
                PickBackpack.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickBackpack.SetActive(false);
    }
}
