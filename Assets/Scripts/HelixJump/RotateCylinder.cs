using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateCylinder : MonoBehaviour
{
    public float rotateSpeed;
    float moveX;
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, moveX * rotateSpeed * Time.deltaTime, 0f);
        }
    }
}
