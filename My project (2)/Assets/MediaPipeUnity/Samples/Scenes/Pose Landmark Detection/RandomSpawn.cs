using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{

    private int rand;
    public Sprite[] Sprite_Pic;
    [SerializeField] private float timer = 10f;
    private bool isTouched = false;
    public float tempTimer;

    void Start()
    {
        tempTimer = timer;
        Change();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTouched) return;
        tempTimer -= Time.deltaTime;

        if (!(tempTimer <= 0)) return;
        isTouched = false;
        tempTimer = timer;

    }
    public void Change()
    {
        rand = Random.Range(0, Sprite_Pic.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
    }
}
