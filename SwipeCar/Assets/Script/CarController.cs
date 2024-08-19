using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
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
            if (mouseEnd.x - mouseStart.x > 0)
            {
                speed = 0.1f;
            }
            else
            {
                speed = -0.1f;
            }
            
        }

        this.transform.Translate(speed, 0,0);
        //Input.GetMouseButtonDown(0)

        speed *= 0.96f;
    }
}
