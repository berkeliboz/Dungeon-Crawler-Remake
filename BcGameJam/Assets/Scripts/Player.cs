using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseCharacterClass {

    Vector3 MovementVector;
    float xAxisSpeed;
    float yAxisSpeed;

    public void Start()
    {

    }

    public void Update()
    {
        xAxisSpeed = Input.GetAxis("Horizontal") * Time.deltaTime;
        yAxisSpeed = Input.GetAxis("Vertical") * Time.deltaTime;

        MovementVector = new Vector3(xAxisSpeed, yAxisSpeed,0f);
        transform.position += MovementVector;

    }

}
