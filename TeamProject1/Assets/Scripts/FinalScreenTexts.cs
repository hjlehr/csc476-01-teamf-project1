using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScreenTexts : MonoBehaviour
{
    public Text Tittle;
    public Button button;
    public Button ExitButton;
    public Text YourScore;
    public Text HighestScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tittle.transform.position = new Vector3(Screen.width / 2, Screen.height - Screen.height / 3, 0);
        button.transform.position = new Vector3(Screen.width / 3, Screen.height / 3, 0);
        ExitButton.transform.position = new Vector3(Screen.width - Screen.width / 3, Screen.height / 3, 0);
        YourScore.transform.position = new Vector3(Screen.width / 3, Screen.height / 8, 0);
        HighestScore.transform.position = new Vector3(Screen.width - Screen.width / 3, Screen.height / 8, 0);
    }
}
