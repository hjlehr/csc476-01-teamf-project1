using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static int score = 0;
    public static int HighestScore = 0;
    public static float HighestScoreTimer = 0;
    public static bool ReachedHighestScore = false;
    public static bool SameTimer = false;
    public static bool WorseTimer = false;
    public static bool BetterTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighestScore = PlayerPrefs.GetInt("HighScore");
            HighestScoreTimer = PlayerPrefs.GetFloat("HighScoreTimer");
        }
        PlayerPrefs.SetInt("HighScore", HighestScore);
    }
    // Update is called once per frame
    void Update()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.SetFloat("HighScoreTimer", Cameragaa.timer);
            ReachedHighestScore = true;
        }
        if (Cameragaa.Finished)
        {
            if (score == HighestScore)
            {
                if (Cameragaa.timer < HighestScoreTimer)
                {
                    BetterTimer = true;
                    HighestScoreTimer = Cameragaa.timer;
                    PlayerPrefs.SetFloat("HighScoreTimer", Cameragaa.timer);
                }
                else if (Cameragaa.timer > HighestScoreTimer)
                    WorseTimer = true;   
                else
                    SameTimer = true;
            }
        }
    }
    private void OnGUI()
    {
        if (ReachedHighestScore)
            GUI.Label(new Rect(0,0,150,150), "You have the new High Score!");
        if (BetterTimer)
            GUI.Label(new Rect(0, 0, 150, 150), "You finished " + (HighestScoreTimer-Cameragaa.timer) + " seconds faster");
        else if (WorseTimer)
            GUI.Label(new Rect(0, 0, 150, 150), "You finished " + (Cameragaa.timer - HighestScoreTimer) + " seconds slower");
        else if (SameTimer)
            GUI.Label(new Rect(0, 0, 150, 150), "You finished in the same timea as the last Highest Score");
    }
}
