using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpereMovementScript : MonoBehaviour
{
    float decimalNumber;
    int wholeNumber;
    Vector3 threefloats;

    int randomXPositionThatIsLeftOrRight;

    int spinX = 5;
    int spinY = 10;
    int spinZ = 3;

    // Start is called before the first frame update
    void Start()
    {
        wholeNumber = 4;
        decimalNumber = 4.021f;
        threefloats = new Vector3(2.0f, 1.0f, 3.333f);
        threefloats.y = 4.23f;
    }

    // Update is called once per frame
    void Update()
    {
        //MoveTheSphereToEitherTheLeftOrRightOfScreen();
        //MoveTheSphereDeeperIntoTheScreen();
        MoveTheSphereCloserToTheScreen();
        SpinSphereInPlace();


    }

    void MoveTheSphereToEitherTheLeftOrRightOfScreen()
    {
        randomXPositionThatIsLeftOrRight = Random.Range(0, 2);
        transform.position = new Vector3(-10 + 20, transform.position.y, transform.position.z);

    }

    void MoveTheSphereDeeperIntoTheScreen()
    {
         
        transform.position = transform.position + Vector3.forward * Time.deltaTime * 10;
    }

    void MoveTheSphereCloserToTheScreen()
    {
        transform.position = transform.position + Vector3.back * Time.deltaTime * 5;

    }

    void SpinSphereInPlace()
    {
        transform.Rotate(spinX, spinY, spinZ);

    }
}
