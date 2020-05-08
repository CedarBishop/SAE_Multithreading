using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHolder : MonoBehaviour
{
    public static SpriteHolder instance = null;

    public Sprite[] sprites;

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

    public Sprite GetRandomSprite ()
    {
        print("Getting random sprite");
        if (sprites == null)
        {
            return null;
        }

        return sprites[Random.Range(0, sprites.Length)];
    }
}
