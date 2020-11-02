using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cameragaa : MonoBehaviour
{
    public static float lives = 3;
    public static float score;
    public static Vector3 ballInitialPos;
    public GameObject ball;
    public Text ScoreText;
    public Text LivesText;

    // Start is called before the first frame update
    void Start()
    {
        ballInitialPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        score = (float) (int) Time.time;
        
        ScoreText.text = score.ToString();
        LivesText.text = lives.ToString();
    }
}
