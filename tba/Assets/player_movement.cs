using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 10f;
    SpriteRenderer spi;
    // Start is called before the first frame update
    void Start()
    {
        spi = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {float inputX = Input.GetAxis("Horizontal");
     float inputY = Input.GetAxis("Vertical");
     
     Vector3 movement = new Vector3(speed * inputX, speed * inputY, 0);

     if (inputX == -1 && spi.flipX == false){
            spi.flipX = true;
        }else if (inputX == 1 && spi.flipX == true){
            spi.flipX = false;
        }

     movement *= Time.deltaTime;

     transform.Translate(movement);
        
    }
}
