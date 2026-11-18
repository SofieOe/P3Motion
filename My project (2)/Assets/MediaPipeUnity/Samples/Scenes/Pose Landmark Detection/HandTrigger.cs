using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;


public class HandTrigger : MonoBehaviour
{
  public RandomSpawn randomSpawn;
  public PointsRightorWrong pointScript;
  public Constraints constraints;
    private float timer =5f;
    public bool isTouched = false;
    public float tempTimer;

    public GameObject loadingImage;
    public GameObject LoadingZone;

    

    void Start()
    {
        tempTimer = timer;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTouched) return;

        if (isTouched)
        {
            tempTimer -= Time.deltaTime;
            Debug.Log("Det her er tiden "+tempTimer);
        }


        if (!(tempTimer <= 0)) return;
        
       
        Debug.Log("point script i hand trigger blir kaldt");
        randomSpawn.Change();
        pointScript.PointMath();
        isTouched = false;

        loadingImage.SetActive(false); 
        
        tempTimer = timer;
        
        
        StartCoroutine(WaitForSeconds(5f));
         
        //Debug.Log("vi venter");


    }

    public IEnumerator WaitForSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        
        //Debug.Log("inde i enumerator");
        //Debug.Log("her er delay " + delay);
    }
 public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Hand")) 
      {
        isTouched = true;
        loadingImage.SetActive(true); //når vi interegere så bliver loading enabled
        if(collision.gameObject != LoadingZone)
        {
          LoadingZone.SetActive(false);
          
         
        }


        //Debug.Log("Hand is here");
      }
    else return;
    //Debug.Log("else return hand trigger");
    //Debug.Log(collision.gameObject.tag);
  }
  public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
          isTouched = false;
          loadingImage.SetActive(false);
          if(collision.gameObject != LoadingZone)
          {
            LoadingZone.SetActive(true);
            
          }

          
          
          
          
        }
        
        //Debug.Log("Hand is gone");
    }

    /*private void pointCounter()
    {
      if (CompareTag("LeftDoor"))
      {
        pointScript.WrongPoint ++;
        pointScript.RightPoint ++;
      }
      if (CompareTag("RightDoor"))
      {
        pointScript.WrongPoint ++;
        pointScript.RightPoint ++;
      }
      Debug.Log("det her er point forkert " + pointScript.WrongPoint);
      Debug.Log("det her er point rigtigt " + pointScript.RightPoint);
    }*/


}
