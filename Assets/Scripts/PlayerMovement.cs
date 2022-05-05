using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{



    public float speed = 5.0f;
    public GameManager gameManager;



    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        transform.Translate(xMovement, yMovement, 0);
        //transform.position = new Vector3(transform.position.x + xMovement, transform.position.y + yMovement, transform.position.z);

    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        

    }

        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("Area Cleared");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }

        
        
    }

    

}

    
   

