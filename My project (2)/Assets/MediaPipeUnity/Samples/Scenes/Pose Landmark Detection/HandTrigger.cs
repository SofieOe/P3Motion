using UnityEngine;

public class HandTrigger : MonoBehaviour
{
  public RandomSpawn randomSpawn;
    private float timer =5f;
    private bool isTouched = false;
    public float tempTimer;

    void Start()
    {
        tempTimer = timer;
        Debug.Log("Temptimer=timer randomspawn");
        Debug.Log("Start Change ting");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTouched) return;
        Debug.Log("if !istouched randomspawner");
        if (isTouched)
        {
            tempTimer -= Time.deltaTime;
            Debug.Log("respawn timer" + tempTimer);
        }

        if (!(tempTimer <= 0)) return;
       
        Debug.Log("if randomspawner temptimer hand trigger");
        randomSpawn.Change();
        
        
        Debug.Log("HandTRigger randomspawn change");
        Debug.Log("If temptimer return randomspawn");
        isTouched = false;
        tempTimer = timer;

        Debug.Log("this time" + tempTimer);
        Debug.Log(isTouched);

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
