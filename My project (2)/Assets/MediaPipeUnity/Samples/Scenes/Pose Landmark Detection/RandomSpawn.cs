using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{
    private int rand;
    public GameObject[] gameObjectPicture;

    void Start()
    {
        Change();
    }

    // Update is called once per frame

    public void Change()
    {
        /*rand = Random.Range(0, Sprite_Pic.Length);
        Debug.Log("Rand");
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
        var parent = gameObject.transform as RectTransform;
        var sprite = GetComponent<SpriteRenderer>().sprite;
        parent.localScale = parent.rect.size / sprite.rect.size * sprite.pixelsPerUnit;
        Debug.Log("getcompRand");*/

        foreach (GameObject picture in gameObjectPicture)
        {
            for (int i = 0; i < picture.transform.childCount; i++)
            {
                picture.transform.GetChild(i).gameObject.SetActive(false);
            }

            rand = Random.Range(0, picture.transform.childCount);

            picture.transform.GetChild(rand).gameObject.SetActive(true);

        }
        
    }
}
