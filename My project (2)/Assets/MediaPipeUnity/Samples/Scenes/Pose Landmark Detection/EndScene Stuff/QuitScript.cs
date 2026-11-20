using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ExitGame() 
    {
        Application.Quit();
        Debug.Log("quitting");
    }
}