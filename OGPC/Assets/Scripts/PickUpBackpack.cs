using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpBackpack : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PickBackpack;
    public TextMeshProUGUI backpackQuest;
    public Color doneColor;

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
                backpackQuest.color = doneColor;
                PickBackpack.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickBackpack.SetActive(false);
    }
}
