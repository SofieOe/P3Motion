using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransition : MonoBehaviour
{
   public string scene;
   public void transition()
   {
       SceneManager.LoadScene(scene, LoadSceneMode.Single);
   }
 
}