using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Constraints : MonoBehaviour
{
        public bool Sandt = false;
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
        YellowLamp = GameObject.FindGameObjectsWithTag("YellowLamp");
        OffLamp = GameObject.FindGameObjectsWithTag("OffLamp");
        Painting = GameObject.FindGameObjectsWithTag("Painting");
        Debug.Log("Count Kører");
    }

    public void Rules()
    {
        Debug.Log("Bøger "+ randomSpawn.ActiveBook);
        Debug.Log("Sandt lololol "+Sandt);
        //3 book
        if (randomSpawn.ActiveBook == 3)
        {
            Debug.Log("is 3");
            if (YellowBook.Length == 1 && LightBlueBook.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør, 3 bøger, Gulbog+Blåbog");
            }
            else if (GreenBook.Length == 2 && BlueLamp.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg højre dør, 3 bøger, grønbog+blålampe");
            }
        }

        //4 book
        else if (randomSpawn.ActiveBook == 4)
        {
            Debug.Log("is 4");
            if (OrangeBook.Length >= 2)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør 4 bøger, min 2 orange");
            }
            else if (PinkBook.Length >= 1 && FlowerPlant.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg højre dør, 4 bøger, minimum pinkbog + blomst");
            }
            else if (PurpleBook.Length == 1 && LightBlueBook.Length == 1 && YellowBook.Length == 1 && GreenBook.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør, 4 bøger, lilla+blå+gul+grønbog");
            }
        }

        //5 book
        else if (randomSpawn.ActiveBook == 5)
        {
            Debug.Log("is 5");
            if (Painting.Length == 2)
            {
                Sandt = true;
                Debug.Log("Vælg højre dør 2 aktive billeder");
            }
            else if (PinkBook.Length == 2 && PurpleBook.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør 5 bøger, 2 pinke + 1 lillabog");
            }
            else if (GreenBook.Length == 1 && LightBlueBook.Length == 1 && PurpleBook.Length == 1 && OrangeBook.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg højre dør, 5 bøger, 1 grøn, 1 blå, 1 lilla, 1 orange");
            }
            else if (PinkBook.Length >= 2)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør, minimum 2 pinke bøger");
            }
        }

        //6 book
        else if (randomSpawn.ActiveBook == 6)
        {
            Debug.Log("is 6");
            if (PurpleBook.Length == 2 && YellowBook.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør, 6 bøger, 2 lilla + 1 gul");
            }
            else if (YellowBook.Length == 2 && PurpleBook.Length == 1)
            {
                Sandt = true;
                Debug.Log("Vælg højre dør, 6 bøger, 1 gul + 2 lilla");
            }
            else if (LightBlueBook.Length == 3)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør, 6 bøger, 3 blå");
            }
            else if (YellowBook.Length == 2 && LightBlueBook.Length == 2)
            {
                Sandt = true;
                Debug.Log("Vælg højre dør, 6 bøger, 2 gule + 2 blå");
            }
            else if (PinkBook.Length == 3)
            {
                Sandt = true;
                Debug.Log("Vælg venstre dør, 6 bøger, 3 pink");
            }
        }
        Debug.Log("Sandt efter "+Sandt);

        //Dør + symboler
        if (Sandt != true) 
        {
            Debug.Log("VI KLAREDE DEN");
            if (DoorBrown.Length == 1 && Triangle.Length == 1)
            {
                Debug.Log("Vælg højre dør, 1 brun dør + 1 trekant");
            }
            else if (DoorRed.Length == 1 && Star.Length == 1)
            {
                Debug.Log("Vælg venstre dør, 1 rød dør + 1 stjerne");
            }
            else if (DoorRed.Length == 2 && Square.Length == 1)
            {
                Debug.Log("Vælg venstre dør, 2 røde dør + 1 firkant");
            }
            else if (Square.Length == 1)
            {
                Debug.Log("Vælg højre dør, 1 firkant");
            }
            else if (DoorBlue.Length == 1 && Circle.Length == 1 || Heart.Length == 1)
            {
                Debug.Log("Vælg venstre dør, 1 blå dør + 1 cirkel ELLER 1 hjerte");
            }
            else if (DoorBlue.Length == 2 || DoorRed.Length == 2 || DoorBrown.Length == 2 && Triangle.Length == 2 || Square.Length == 2)
            {
                Debug.Log("Vælg højre dør, 2 blå dør ELLER 2 rød dør ELLER 2 brun dør OG 2 trekant ELLER 2 firkanter");
            }

            //Plante + billede + lampe
            else if (Painting.Length == 2 && YellowLamp.Length == 1)
            {
                Debug.Log("Vælg højre dør, 2 billeder + 1 gul lampe");
            }
            else if (Plant.Length == 1 && BlueLamp.Length == 1)
            {
                Debug.Log("Vælg venstre dør, 1 plante, 1 blå lampe");
            }
            else if (OffLamp.Length == 1 && Painting.Length >= 1)
            {
                Debug.Log("Vælg højre dør, lampe ikke tændt + minimum 1 billede");
            }
            else if (FlowerPlant.Length == 1 && Plant.Length == 1)
            {
                Debug.Log("Vælg højre dør, 1 blomsterplante + plante");
            }
            else if (FlowerPlant.Length == 2 || Plant.Length == 2)
            {
                Debug.Log("Vælg venstre dør, 2 blomsterplante ELLER 2 planter");
            }

            //Intet passer gør det her :D
            else 
            {
                Debug.Log("Intet passer... Vælg venstre dør :D");
            }
        }
        Sandt = false;
    }
}
