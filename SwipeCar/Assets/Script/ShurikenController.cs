using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UIElements;

public class ShurikenController : MonoBehaviour
{
    public float movePower;
    public bool isMove;
    float yMin = 0f, yMax = 1920f;

    public void Update()
    {
        if (isMove)
        {            
            //z축으로 회전한다
            transform.Rotate(0, 0, -1f);

            //y축으로 이동합니다.
            transform.Translate(0, movePower, 0, Space.World);
                        
        }

        float yPos = Mathf.Clamp(movePower, yMin, yMax);
        movePower *= 0.97f;
        
        
    }
}