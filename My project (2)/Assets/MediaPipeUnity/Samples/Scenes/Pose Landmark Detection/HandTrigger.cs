using UnityEngine;

public class HandTrigger : MonoBehaviour
{
  public RandomSpawn randomSpawn;
 public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Hand")) 
      {
        Debug.Log("Hand is here");
        if (randomSpawn.tempTimer <= 5f)
            {
              Debug.Log("if randomspawner temptimer hand trigger");
                randomSpawn.Change();
                Debug.Log("HandTRigger randomspawn change");
            }
      }
    else return;
    Debug.Log("else return hand trigger");
    Debug.Log(collision.gameObject.tag);
    Debug.Log(randomSpawn.tempTimer);
  }
  public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        return;
        Debug.Log("Hand is gone");
    }
}
