using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
   public void ResetLvl()
   {
     SceneManager.LoadScene(1);
   }

   public void GoBack()
   {
      SceneManager.LoadScene(0);
   }
}
