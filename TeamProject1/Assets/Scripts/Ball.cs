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
                SceneManager.LoadScene("GameOver");
            BoardMovement.rotX = 0;
            BoardMovement.rotZ = 0;
        }
        else if (collision.gameObject.tag == "CorrectHole1")
        {
            SceneManager.LoadScene("SecondLevel");
        }
        else if (collision.gameObject.tag == "CorrectHole2")
        {
            SceneManager.LoadScene("ThirdLevel");
        }
        else if (collision.gameObject.tag == "CorrectHole3")
        {
            SceneManager.LoadScene("FourthLevel");
        } else if (collision.gameObject.tag == "CorrectHole4")
        {
            SceneManager.LoadScene("Congratulations");
        }
    }
}
