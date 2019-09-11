using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    int spinX = 7;
    int spinY = 4;
    int spinZ = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SpinCylinderInPlace();
    }

    void SpinCylinderInPlace()
    {
        transform.Rotate(spinX, spinY, spinZ);

    }
}
