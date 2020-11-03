using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static int score = 0;
    public static int HighestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
            HighestScore = PlayerPrefs.GetInt("HighScore");
        PlayerPrefs.SetInt("HighScore", HighestScore);
    }
    // Update is called once per frame
    void Update()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", score);
    }
    private void OnGUI()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
            GUI.Label(new Rect(0, 0, 100, 100), "You have the Highest Score!");
    }
}
