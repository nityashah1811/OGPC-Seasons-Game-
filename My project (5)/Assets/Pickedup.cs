using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickedup : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PickBackpack;

    void Start()
    {
        PickBackpack.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Character")
        {

            PickBackpack.SetActive(true);

            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);

                PickBackpack.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickBackpack.SetActive(false);
    }
}
