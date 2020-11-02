using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongHole : MonoBehaviour
{
    public GameObject ball;
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
        if (collision.gameObject == ball)
        {
            ball.transform.position = Cameragaa.ballInitialPos;
            --Cameragaa.lives;
            if(Cameragaa.lives == 0)
                SceneManager.LoadScene("GameOver");
        }
    }
}
