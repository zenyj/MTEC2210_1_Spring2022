using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject carPrefab;
    public Transform[] carSpawnPoints;
    
    void Start()
    {
        SpawnCar();
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCar();
        }

       
        
    }

    void SpawnCar()
    {
        int index = Random.Range(0, carSpawnPoints.Length);
        Vector3 spawnPos = carSpawnPoints[index].position;

        GameObject car =Instantiate(carPrefab, spawnPos, Quaternion.identity);



        int dirModifier = 0;

        if(index>2)
            {
            dirModifier = -1;
        }
        else
        {
            dirModifier = 1;
        }
  
        //int dirModifier = (index > 2 ) ? -1 : 1;

        car.GetComponent<CarMovement>().speed = Random.Range(3.0f, 6.0f) * dirModifier;
        car.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
       

    }
}

