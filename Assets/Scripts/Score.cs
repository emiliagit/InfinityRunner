using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoreTEXT;
    public float contadorScore = 0f;
    //public TextMeshProUGUI highScoreTEXT;
    private float highScore = 0f;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("highScore", 0f);
        UpdateHighScoreText();

    }

    // Update is called once per frame
    void Update()
    {
        contadorScore += Time.deltaTime;
        scoreTEXT.text = "Score: " +  (contadorScore * 10).ToString("00000");

        if(contadorScore > highScore)
        {
            highScore = contadorScore;
            PlayerPrefs.SetFloat("HighScore", highScore);
            UpdateHighScoreText();

        }
    }

    public void UpdateHighScoreText()
    {
        //highScoreTEXT.text = "High SCore: " + (highScore * 10).ToString("00000");
    }

}
