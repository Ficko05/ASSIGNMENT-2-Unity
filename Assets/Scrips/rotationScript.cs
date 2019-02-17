using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{


    

    void Start()
    {
        
    }

   
    void Update()
    {
        
        transform.Rotate(Vector3.right * Time.deltaTime);

        
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
    }
}
