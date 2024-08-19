using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    float speed = 0;
    float rotateSpeed = 0;
    Vector3 mouseStart;
    Vector3 mouseEnd;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseStart = Input.mousePosition;

        }

        if (Input.GetMouseButtonUp(0))
        {
            mouseEnd = Input.mousePosition;
            if (mouseEnd.y - mouseStart.y > 0)
            {
                rotateSpeed = 1;
                speed = 0.01f;
            }

        }

        this.transform.Rotate(0, 0, rotateSpeed);
        this.transform.Translate(0,speed,0, Space.World);
        
    }
}
