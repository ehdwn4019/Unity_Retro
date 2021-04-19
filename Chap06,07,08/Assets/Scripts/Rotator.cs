using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    float count = 0f;

    // Update is called once per frame
    void Update()
    {
        //원래코드
        //transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);

        count += Time.deltaTime;

        if (count>=3.0f)
        {
            transform.Rotate(0f, -rotationSpeed * Time.deltaTime, 0f);
            if(count>=6.0f)
            {
                count = 0;
            }

        }
        else
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
    }
}
