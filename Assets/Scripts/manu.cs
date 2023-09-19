using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manu : MonoBehaviour
{
   public void OnPlayerButton()
    {
        SceneManager.LoadScene(1);
    }

    public void onquitButton()
    {
        Application.Quit();
    }
}


