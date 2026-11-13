using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class HandTrigger : MonoBehaviour
{
  public RandomSpawn randomSpawn;
  public Constraints constraints;
    private float timer =5f;
    private bool isTouched = false;
    public float tempTimer;

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
      
        randomSpawn.Change();
        isTouched = false;
        tempTimer = timer;
        StartCoroutine(WaitForSeconds(5f));
        Debug.Log("vi venter");


    }

    public IEnumerator WaitForSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("inde i enumerator");
        Debug.Log("her er delay " + delay);
    }
 public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Hand")) 
      {
        isTouched = true;
        Debug.Log("Hand is here");
      }
    else return;
    Debug.Log("else return hand trigger");
    Debug.Log(collision.gameObject.tag);
  }
  public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
          isTouched = false;
        }
        Debug.Log("Hand is gone");
    }
}
