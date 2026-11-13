using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Constraints : MonoBehaviour
{
        public RandomSpawn randomSpawn;
        public GameObject[] DoorBlue;
        public GameObject[] DoorRed;
        public GameObject[] DoorBrown;
        public GameObject[] Circle;
        public GameObject[] Square;
        public GameObject[] Star;
        public GameObject[] Triangle;
        public GameObject[] Heart;
        public GameObject[] GreenBook;
        public GameObject[] LightBlueBook;
        public GameObject[] OrangeBook;
        public GameObject[] PinkBook;
        public GameObject[] YellowBook;
        public GameObject[] PurpleBook;
        public GameObject[] FlowerPlant;
        public GameObject[] Plant;
        public GameObject[] YellowLamp;
        public GameObject[] BlueLamp;
        public GameObject[] OffLamp;
        public GameObject[] Painting;

    
    public void Count()
    { 
        DoorBlue = GameObject.FindGameObjectsWithTag("DoorBlue");
        DoorRed = GameObject.FindGameObjectsWithTag("DoorRed");
        DoorBrown = GameObject.FindGameObjectsWithTag("DoorBrown");
        Circle = GameObject.FindGameObjectsWithTag("Circle");
        Square = GameObject.FindGameObjectsWithTag("Square");
        Star = GameObject.FindGameObjectsWithTag("Star");
        Heart = GameObject.FindGameObjectsWithTag("Hearth");
        Triangle = GameObject.FindGameObjectsWithTag("Triangle");
        GreenBook = GameObject.FindGameObjectsWithTag("GreenBook");
        LightBlueBook = GameObject.FindGameObjectsWithTag("LightBlueBook");
        OrangeBook = GameObject.FindGameObjectsWithTag("OrangeBook");
        PinkBook = GameObject.FindGameObjectsWithTag("PinkBook");
        YellowBook = GameObject.FindGameObjectsWithTag("YellowBook");
        PurpleBook = GameObject.FindGameObjectsWithTag("PurpleBook");
        FlowerPlant = GameObject.FindGameObjectsWithTag("FlowerPlant");
        Plant = GameObject.FindGameObjectsWithTag("Plant");
        BlueLamp = GameObject.FindGameObjectsWithTag("BlueLamp");
        YellowBook = GameObject.FindGameObjectsWithTag("YellowLamp");
        OffLamp = GameObject.FindGameObjectsWithTag("OffLamp");
        Painting = GameObject.FindGameObjectsWithTag("Painting");
        Debug.Log("Count Kører");
    }

    public void Rules()
    {
        Debug.Log("Bøger"+ randomSpawn.ActiveBook);
        //3 book
        if (randomSpawn.ActiveBook == 3)
        
        {
            Debug.Log("is 3");
            if (YellowBook.Length == 1 && LightBlueBook.Length == 1)
            {
                Debug.Log("Vælg venstre dør, 3 bøger, Gulbog+Blåbog");
            }
            else if (GreenBook.Length == 2 && BlueLamp.Length == 1)
            {
                Debug.Log("Vælg højre dør, 3 bøger, grønbog+blålampe");
            }
            else
            {
                Debug.Log("Ingen 3 bøger nej nej");
            }
            
        }

        //4 book
        if (randomSpawn.ActiveBook == 4)
        {
            if (OrangeBook.Length >= 2)
            {
                Debug.Log("Vælg venstre dør 4 bøger, min 2 orange");
            }
            else if (PinkBook.Length == 1 && FlowerPlant.Length == 1)
            {
                Debug.Log("Vælg højre dør, 4 bøger, pinkbog + blomst");
            }
            else if (PurpleBook.Length == 1 && LightBlueBook.Length == 1 && YellowBook.Length == 1 && GreenBook.Length == 1)
            {
                Debug.Log("Vælg venstre dør, 4 vøger, lilla+blå+gul+grønbog");
            }
            else
            {
                Debug.Log("Ikke 4 bøger");
            }
        }
    }
}
