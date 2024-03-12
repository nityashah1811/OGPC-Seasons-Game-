using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Applemanager : MonoBehaviour
{
    public static Applemanager Instance { get; private set; }

    public TextMeshProUGUI appleText;
    private int appleCount = 0;
    public Color donecolor;

    void Awake()
    {
        Instance = this;
    }

    public void IncreaseAppleCount()
    {
        appleCount++;
        appleText.text = $"Pick up the Apples [{appleCount}/5]";

        if (appleCount == 5)
        {
            appleText.color = donecolor;
        }
    }

}
