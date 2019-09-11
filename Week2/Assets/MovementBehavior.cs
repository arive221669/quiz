using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{

    float speed = 1;
    int randomPositionForCube;

    /* Variables are only available within the scope of the function that they are in. */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //transform.position += Vector3.up * .001f;
        //this.transform.position = this.transform.position + new Vector3(0, .001f, 0);

        GenerateANewRandomIntegerAndPutItInRandomPositionForCube();
        TeleportCubeLeftAndRight();
        MoveCubeOffTheTopOfTheScreen();


       // transform.position = new Vector3(randomint, transform.position.y, 0);
       // transform.position += Vector3.up * Time.deltaTime * speed; 
    }

    void GenerateANewRandomIntegerAndPutItInRandomPositionForCube() {

        randomPositionForCube = Random.Range(-10, 11);

    }

    void TeleportCubeLeftAndRight()
    {

        transform.position = new Vector3(randomPositionForCube, transform.position.y + speed * Time.deltaTime, 0);

    }

    void MoveCubeOffTheTopOfTheScreen()
    {
        transform.position += Vector3.up * Time.deltaTime * speed;

    }
}
