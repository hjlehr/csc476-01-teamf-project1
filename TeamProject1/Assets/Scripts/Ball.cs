using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public static bool crashed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WrongHole")
        {
            crashed = true;
            transform.position = Cameragaa.ballInitialPos;
            --Cameragaa.lives;
            if (Cameragaa.lives == 0)
            {
                SceneManager.LoadScene("GameOver");
                Cameragaa.Finished = true;
            }
            BoardMovement.rotX = 0;
            BoardMovement.rotZ = 0;
        }
        else if (collision.gameObject.tag == "CorrectHole1")
        {
            HighScore.score += (int)(Cameragaa.FirstLevelScore * Cameragaa.lives);
            SceneManager.LoadScene("SecondLevel");
        }
        else if (collision.gameObject.tag == "CorrectHole2")
        {
            HighScore.score += (int)(Cameragaa.SecondLevelScore * Cameragaa.lives);
            SceneManager.LoadScene("ThirdLevel");
        }
        else if (collision.gameObject.tag == "CorrectHole3")
        {
            HighScore.score += (int)(Cameragaa.ThirdLevelScore * Cameragaa.lives);
            SceneManager.LoadScene("FourthLevel");
        } else if (collision.gameObject.tag == "CorrectHole4")
        {
            HighScore.score += (int)(Cameragaa.FourthLevelScore * Cameragaa.lives);
            Cameragaa.Finished = true;
            SceneManager.LoadScene("Congratulations");
        }
    }
}
