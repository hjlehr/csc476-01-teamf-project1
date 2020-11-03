using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cameragaa : MonoBehaviour
{
    public static float lives = 3;
    public static float timer;
    public static int FirstLevelScore = 10;
    public static int SecondLevelScore = 50;
    public static int ThirdLevelScore = 250;
    public static int FourthLevelScore = 1250;
    public static Vector3 ballInitialPos;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ballInitialPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer = (float)(int)Time.time;
    }
 
}
