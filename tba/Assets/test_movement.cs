using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_movement : MonoBehaviour
{
    public Vector2 speed = new Vector2(50,50);

    // Update is called once per frame
    void Update()
    {
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(speed.x*inputX, speed.y*inputY, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
