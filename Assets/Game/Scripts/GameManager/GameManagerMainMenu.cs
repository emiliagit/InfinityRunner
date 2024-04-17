using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMainMenu : MonoBehaviour
{
    //public GameObject tutorialCanvas;
    //public GameObject MainMenuCanvas;

    //private bool tutorialActive = false;



    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

   

    public void ExitButton()
    {
        Application.Quit();
    }

  
}
