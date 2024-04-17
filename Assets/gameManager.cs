using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene("GameScene");

    }


    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
