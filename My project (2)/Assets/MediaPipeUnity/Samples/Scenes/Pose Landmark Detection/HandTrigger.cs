using UnityEngine;

public class HandTrigger : MonoBehaviour
{
 private void OnTriggerEnter(Collider collider)
  {
    if (collider.gameObject.CompareTag("Hand"))
    Debug.Log("Hand is here");
    else return;
  }
  private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Hand"))
        return;
        Debug.Log("Hand is gone");
    }
}
