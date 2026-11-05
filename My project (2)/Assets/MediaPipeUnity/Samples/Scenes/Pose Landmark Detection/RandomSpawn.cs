using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{

    private int rand;
    public Sprite[] Sprite_Pic;
    [SerializeField] private float timer;
    private bool isTouched = true;
    public float tempTimer;

    void Start()
    {
        tempTimer = timer;
        Debug.Log("Temptimer=timer randomspawn");
        Change();
        Debug.Log("Start Change ting");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTouched) return;
        Debug.Log("if !istouched randomspawner");
        tempTimer -= Time.deltaTime;
        Debug.Log("Temptimer - deltatime");

        if (!(tempTimer <= 0)) return;
        Debug.Log("If temptimer return randomspawn");
        isTouched = false;
        Debug.Log("false");
        tempTimer = timer;
        Debug.Log("Timer Update ting");

        Debug.Log("this time" + tempTimer);
        Debug.Log(isTouched);
    }
    public void Change()
    {
        rand = Random.Range(0, Sprite_Pic.Length);
        Debug.Log("Rand");
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
        Debug.Log("getcompRand");
    }
}
