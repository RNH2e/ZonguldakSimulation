using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void yenidenOyna(int yeniden)
    {
      
            SceneManager.LoadScene(0);    
    }
    public void doExitGame()
    {
        Application.Quit();
    }

   
}
