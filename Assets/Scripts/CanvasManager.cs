using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance = null;

    public Text text;

    private int count = 1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    public void IncrementSpawnText (int amount)
    {
        count += amount;
        text.text = "Num of units: " + count.ToString();
    }
}
