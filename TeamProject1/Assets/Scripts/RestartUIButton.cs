using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartUIButton : MonoBehaviour
{
    public Button RestartButton;
    public Text HighestScore;
    public Text CurrentScore;
    public Button Exit;
    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(Restart);
        Exit.onClick.AddListener(ExitGame);
        HighestScore.text = "Highest Score: " + HighScore.HighestScore.ToString();
        CurrentScore.text = "Your Score: " + HighScore.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Restart()
    {
        SceneManager.LoadScene("FirstLevel");
        Cameragaa.lives = 3;
        Cameragaa.timer = 0;
        Cameragaa.Finished = false;
        HighScore.ReachedHighestScore = false;
        HighScore.BetterTimer = false;
        HighScore.WorseTimer = false;
        HighScore.SameTimer = false;
        HighScore.score = 0;
    }
    void ExitGame()
    {
        Application.Quit();
    }
}
