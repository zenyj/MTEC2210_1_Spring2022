using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{



    public float speed = 5.0f;




    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        transform.Translate(xMovement, yMovement, 0);
        //transform.position = new Vector3(transform.position.x + xMovement, transform.position.y + yMovement, transform.position.z);




        }

    
   
}
