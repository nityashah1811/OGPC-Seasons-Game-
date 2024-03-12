using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questActivate : MonoBehaviour
{
    public GameObject quests;
    private bool questOn = false;

    void Start()
    {
        // Initialize with the current active state of the object
        quests.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'Q' key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Toggle the active state
            questOn = !questOn;
            quests.SetActive(questOn);
            Debug.Log("quest");
           
        }
    }
}