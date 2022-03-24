using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{



    void Update()
    {
        //Vector3.up (etc)
        transform.position += (Vector3.right * Time.deltaTime);
    }
}
