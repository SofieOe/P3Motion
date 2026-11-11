using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{
    private int rand;
    private int spawnChance;
    public GameObject[] gameObjectBook;
    public GameObject[] gameObjectPlants;
    public GameObject[] gameObjectPicture;
    public GameObject[] gameObjectRest;

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

        BookSpawn();
        Debug.Log("bookspawn");
        PictureSpawn();
        Debug.Log("Pucturespawn");
        RestSpawn();
        Debug.Log("restspawn");
        PlantSpawn();
        Debug.Log("plantspawn");
        
    }


    public void BookSpawn()
    {
        /*foreach (GameObject book in gameObjectBook)
        {
            for (int i = 0; i < book.transform.childCount; i++)
            {
                book.transform.GetChild(i).gameObject.SetActive(false);
            }
            spawnChance = Random.Range(1, 100);
            
            Debug.Log("spawnchange er "+ spawnChance);
            if (spawnChance <= 75)
            {
                Debug.Log(rand+"child " + book.transform.childCount);
                rand = Random.Range(0, book.transform.childCount-1); 
                book.transform.GetChild(rand).gameObject.SetActive(true);
            }

        }*/

        for (int i = 0; i < gameObjectBook.Length-1; i++)
        {
            for (int j = 0; j < gameObjectBook[i].transform.childCount; j++)
            {
                gameObjectBook[i].transform.GetChild(j).gameObject.SetActive(false);
            }
            spawnChance = Random.Range(1, 100);
            
            Debug.Log("spawnchange er "+ spawnChance);
            if (i >= 3 && spawnChance <= 75)
            {

                Debug.Log(rand+"child " + gameObjectBook[i].transform.childCount);
                rand = Random.Range(0, gameObjectBook[i].transform.childCount-1); 
                gameObjectBook[i].transform.GetChild(rand).gameObject.SetActive(true);
            } 
            else if (i < 3)
            {
                rand = Random.Range(0, gameObjectBook[i].transform.childCount-1); 
                gameObjectBook[i].transform.GetChild(rand).gameObject.SetActive(true);
            }
        }

    }
    public void PictureSpawn()
    {
        foreach (GameObject picture in gameObjectPicture)
        {
            for (int i = 0; i < picture.transform.childCount; i++)
            {
                picture.transform.GetChild(i).gameObject.SetActive(false);
            }

            rand = Random.Range(0, (picture.transform.childCount-1)*2);

            if (rand <= picture.transform.childCount-1)
            {
                picture.transform.GetChild(rand).gameObject.SetActive(true);
            }
        }

        

    }

    public void RestSpawn()
    {
        foreach (GameObject rest in gameObjectRest)
        {
            for (int i = 0; i < rest.transform.childCount; i++)
            {
                rest.transform.GetChild(i).gameObject.SetActive(false);
            }

            rand = Random.Range(0, rest.transform.childCount-1); //pga 0 index i random
            rest.transform.GetChild(rand).gameObject.SetActive(true);

        }

    }

    public void PlantSpawn()
    {
        foreach (GameObject plant in gameObjectPlants)
        {
            for (int i = 0; i < plant.transform.childCount; i++)
            {
                plant.transform.GetChild(i).gameObject.SetActive(false);
            }

            rand = Random.Range(0, plant.transform.childCount+2);
            if (rand <= plant.transform.childCount-1)
            {
                plant.transform.GetChild(rand).gameObject.SetActive(true);
            }
        }
    }

    
}
