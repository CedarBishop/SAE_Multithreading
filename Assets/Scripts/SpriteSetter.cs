using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSetter : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = SpriteHolder.instance.GetRandomSprite();
        Debug.Log("Trying to set sprite");
    }
}
