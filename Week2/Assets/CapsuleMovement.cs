using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(10 * Mathf.Sin(Time.time), 10 * Mathf.Cos(Time.time), 0);

        // output = amplitude(highest and lowest value) * sin(frequency * T + frequencyoffset + );
    }

    // Time.time  == time from the start of project
    // Time.deltaTime == time passed since prev frame.
}
