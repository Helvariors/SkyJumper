using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public GameObject Highscore;
    public static int highscorecount;

    public void HighScoreCount()
    {
        DontDestroyOnLoad(Highscore);
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Score.score > highscorecount)
        {
            highscorecount = Score.score;
        }
        GetComponent<UnityEngine.UI.Text>().text = highscorecount.ToString();
    }
}
