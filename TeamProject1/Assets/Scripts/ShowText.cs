using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowText : MonoBehaviour
{
    public Text CurrentScore;
    public Text Lives;
    public Button RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(RestartCurrent);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentScore.text = "Current Score: " + HighScore.score.ToString();
        Lives.text = "Lives: " + Cameragaa.lives.ToString();
        CurrentScore.transform.position = new Vector3(130, 25, 0);
        Lives.transform.position = new Vector3(Screen.width-70, 25, 0);
        RestartButton.transform.position = new Vector3(Screen.width / 2, 25, 0);
    }
    private void RestartCurrent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
