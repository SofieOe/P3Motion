using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{
    private int rand;
    public Sprite[] Sprite_Pic;

    void Start()
    {
        Change();
    }

    // Update is called once per frame

    public void Change()
    {
        rand = Random.Range(0, Sprite_Pic.Length);
        Debug.Log("Rand");
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
        Debug.Log("getcompRand");
    }
}
