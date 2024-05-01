using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35;
    private float lowBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBound)
        {
            Debug.Log("Game Over!!!!");
            Destroy(gameObject);
        }
    }
}
