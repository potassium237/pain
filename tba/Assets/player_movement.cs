using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {float inputX = Input.GetAxis("Horizontal");
     float inputY = Input.GetAxis("Vertical");
     
     Vector3 movement = new Vector3(speed * inputX, speed * inputY, 0);

     movement *= Time.deltaTime;

     transform.Translate(movement);
        
    }
}
