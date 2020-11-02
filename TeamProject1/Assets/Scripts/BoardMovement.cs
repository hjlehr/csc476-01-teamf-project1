using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    public float speed = 800;
    public static float rotX = 0;
    public static float rotZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    { 
        if (Input.GetKey(KeyCode.LeftArrow))
            rotZ += speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
            rotZ += -speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow))
            rotX += -speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
            rotX += speed * Time.deltaTime;
        Quaternion target = Quaternion.Euler(rotX, 0, rotZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5);

        rotX = 0;
        rotZ = 0;

        if (Ball.crashed)
        {
            transform.rotation = Quaternion.identity;
            Ball.crashed = false;
        }
    }
}
