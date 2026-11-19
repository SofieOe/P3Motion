using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;


public class StartTrigger : MonoBehaviour
{
    private float timer =3f;
    private bool isTouched = false;
    public float tempTimer;

   // public GameObject loadingImage;
    //public GameObject LoadingZone;
    public string scene;

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
      
        isTouched = false;

        //loadingImage.SetActive(false); //her starter vi med at gøre vores loading image false
        
        tempTimer = timer;
        StartCoroutine(WaitForSeconds(3f));
        transition();
        Debug.Log("skiftet scene");
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
        if (collision.gameObject.CompareTag("Hand1")) 
        {
            isTouched = true;
            //loadingImage.SetActive(true); //når vi interegere så bliver loading enabled
           // if(collision.gameObject != LoadingZone)
            //{
            //LoadingZone.SetActive(false);
        }


            Debug.Log("Hand is here");
        }
    //else return;
    //Debug.Log("else return hand trigger");
    //Debug.Log(collision.gameObject.tag);
    //}
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand1"))
        {
          isTouched = false;
          //loadingImage.SetActive(false);
          //if(collision.gameObject != LoadingZone)
          //{
            //LoadingZone.SetActive(true);
         // }
          
        }
        //Debug.Log("Hand is gone");
    }


    public void transition()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
 
}
